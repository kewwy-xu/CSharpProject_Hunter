using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HunterApi.Models;
using System.Collections.Generic;
using HunterApi.Common;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HunterApi.Controllers
{
    [ApiController]
    [Route("api/hunter/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly HunterContext hunterDB;

        public PostController(HunterContext context)
        {
            hunterDB = context;
        }

        [HttpGet]
        public ActionResult<List<Post>> GetAllPosts()
        {
            return hunterDB.Posts.ToList();
        }

        //按postId查询帖子
        [HttpGet("getPostByPostId")]
        public ActionResult<Post> GetPostByPostId(int postId)
        {
            var post = hunterDB.Posts.SingleOrDefault(t => t.PostId == postId);
            if (post != null)
                return post;
            else
                return NotFound();
        }

        //按用户ID查询帖子
        [HttpGet("getUserPosts")]
        public ActionResult<List<Post>> GetUserPosts(int userid)
        {
            var query = hunterDB.Posts.Where(o => o.UserId == userid);
            if (query != null)
                return query.ToList();
            else
                return NotFound();
        }

        //根据userId查询用户收藏的帖子
        [HttpGet("getCollectsByUserId")]
        public ActionResult<List<int>> GetCollectsByUserId(int userId)
        {
            List<int> postIds = new List<int>();
            var collects = hunterDB.Collects.Where(t => t.UserId == userId);
            foreach(var c in collects)
            {

                postIds.Add(c.PostId);
            }
            return postIds;
        }
        /*
        //上传图片
        [HttpPost("uploadImage")] 
        public async Task<ActionResult<bool>> UploadImage([FromForm] IFormFile image)
        {
            var inputName = image.Name;//可以通过IFormFile.Name属性获得每个上传文件，在页面上所属Input type="file"标签的name属性值
            var filePath = @"D:\图片\hunterImage\" + image.FileName;

            if (image.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
            }
            return true;
        }
        */
        //发帖
        [HttpPost("addPost")]
        public ActionResult<Post> AddPost(Post post)
        {
            /*
            var image = post.Image;
            if (image.Length > 0)
            {
                var filePath = Path.Combine("images", post.PostId + image.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            }
            */
            hunterDB.Posts.Add(post);
            hunterDB.SaveChanges();
            return post;
        }

        //删帖
        [HttpDelete("deletePost")]
        public ActionResult DeletePost(int userId, int postId)
        {
            //删除评论
            var comments = hunterDB.Comments.Where(t => t.PostId == postId);
            hunterDB.Comments.RemoveRange(comments);
            //删除收藏
            var collects = hunterDB.Collects.Where(t => t.PostId == postId);
            hunterDB.Collects.RemoveRange(collects);

            //删除帖子
            Post post = new Post() { UserId = userId, PostId = postId };
            hunterDB.Posts.Remove(post);
            hunterDB.SaveChanges();
            return NoContent();
        }

        //修改帖子
        [HttpPut("alterPost")]
        public ActionResult<Post> AlterPost(int postId, Post post)
        {
            var posts = hunterDB.Posts.Where(t => t.PostId == postId);
            if (posts == null)
            {
                return post;
            }
            Post entity = posts.ToList()[0] as Post;
            if (entity == null)
            {
                return entity;
            }

            entity.BriefDescription = post.BriefDescription;
            //entity.PostId = post.PostId;
            entity.PostType = post.PostType;
            entity.Price = post.Price;
            entity.State = post.State;
            entity.Time = post.Time;
            entity.Title = post.Title;
            entity.Type = post.Type;
            entity.UserId = post.UserId;

            hunterDB.Posts.Update(entity);
            hunterDB.SaveChanges();
            return entity;
        }

        //按分类查询
        [HttpGet("queryByItemType")]
        public ActionResult<List<Post>> QueryByItemType(ItemTypes itemType)
        {
            var posts = hunterDB.Posts.Where(t => t.Type == itemType);

            if (posts != null)
                return posts.ToList();
            else
                return NoContent();
        }

        //按关键字搜索全部分类        
        [HttpGet("queryByKeyword")]
        public ActionResult<List<Post>> QueryByKeyword(string keyword)
        {
            if (keyword == null)
            {
                return NoContent();
            }
            List<char> keychar = keyword.ToCharArray().ToList();
            var querybyKeyword = hunterDB.Posts.Where(t => t.Title != null);
            Dictionary<int, double> querybyKeywordDict = new Dictionary<int, double>();
            if (querybyKeyword != null)
            {
                foreach (var p in querybyKeyword)
                {
                    List<char> ptitle = p.Title.ToCharArray().ToList();

                    //去重
                    List<char> sameChar = keychar.Union(ptitle).ToList();
                    //获取字符的重复次数
                    List<int> countK = new List<int>();
                    List<int> countP = new List<int>();
                    foreach (var c in sameChar)
                    {
                        countK.Add(keychar.Where(p => p == c).Count());
                        countP.Add(ptitle.Where(p => p == c).Count());
                    }
                    //计算商
                    double num = 0;
                    //被除数
                    double numA = 0;
                    double numB = 0;
                    for (int i = 0; i < sameChar.Count; i++)
                    {
                        num += countK[i] * countP[i];
                        numA += Math.Pow(countK[i], 2);
                        numB += Math.Pow(countP[i], 2);
                    }
                    double cos = num / (Math.Sqrt(numA) * Math.Sqrt(numB));
                    //相似度大于0.3则选出来
                    if (cos > 0.3)
                        querybyKeywordDict.Add(p.PostId, cos);
                    querybyKeywordDict.OrderBy(o => o.Value);
                }
            }
            List<Post> queryResult = new List<Post>();
            foreach (var d in querybyKeywordDict)
            {
                var query = hunterDB.Posts.Where(t => t.PostId == d.Key).ToList();

                queryResult.Add(query[0]);
            }
            //选取前十输出
            return queryResult.Take(10).ToList();
        }

    }
}
