using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HunterApi.Models;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authentication;
using HunterApi.Common;

namespace HunterApi.Controllers
{
    [ApiController]
    [Route("api/hunter/[controller]")]
    public class ManagePostsController : ControllerBase
    {
        private readonly HunterContext hunterDB;

        public ManagePostsController(HunterContext context)
        {
            hunterDB = context;
        }

        [HttpGet]
        public ActionResult get()
        {
            return NoContent();
        }        

        //发表评论
        [HttpPost("issueComment")]
        public ActionResult<Comment> IssueComment(Comment comment)
        {
            try
            {
                hunterDB.Comments.Add(comment);
                hunterDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return comment;
        }

        //删除评论
        [HttpDelete("deleteComment")]
        public ActionResult DeleteComment(int CommentId)
        {
            try
            {
                var comment = hunterDB.Comments.FirstOrDefault(t => t.CommentId == CommentId);
                if (comment != null)
                {
                    hunterDB.Remove(comment);
                    hunterDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        //查看我的评论
        [HttpGet("queryMyComments")]
        public ActionResult<List<Comment>> QueryMyComments(int userId)
        {
            var comments = hunterDB.Comments.Where(t => t.UserId == userId);
            if (comments != null)
            {
                return comments.ToList();
            }
            else
                return NotFound();
        }

        //根据postId查找全部评论
        [HttpGet("queryCommentsByPostId")]
        public ActionResult<List<Comment>> QueryCommentsByPostId(int postId)
        {
            var query = hunterDB.Comments.Where(t => t.PostId == postId);
            return query.ToList();
        }

        //根据userId和postId查找收藏Id
        [HttpGet("getCollectByUserIdAndPostId")]
        public ActionResult<int> GetCollectByUserIdAndPostId(int userId, int postId)
        {
            try
            {
                var collect = hunterDB.Collects.Single(c => c.UserId == userId && c.PostId == postId);
                return collect.CollectId;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        //收藏
        [HttpPost("collect")]
        public ActionResult<Collect> Collect(Collect c)
        {
            try
            {
                hunterDB.Collects.Add(c);
                hunterDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return c;
        }

        //取消收藏
        [HttpDelete("deleteCollect")]
        public ActionResult DeleteCollect(int collectId)
        {
            try
            {
                var collect = hunterDB.Collects.FirstOrDefault(t => t.CollectId == collectId);
                if (collect != null)
                {
                    hunterDB.Remove(collect);
                    hunterDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }


        //记录交易成功的帖子
        [HttpPost("recordSuccessfulTrade")]
        public ActionResult<SuccessfulTrade> RecordSuccessfulTrade(SuccessfulTrade st)
        {
            try
            {
                hunterDB.SuccessfulTrades.Add(st);
                hunterDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return st;
        }
        //删除交易成功的帖子
        [HttpDelete("deleteSuccessfulTrade")]
        public ActionResult DeleteSuccessfulTrade(int successfulTradeId)
        {
            try
            {
                var st = hunterDB.SuccessfulTrades.FirstOrDefault(t => t.SuccessfulTradeId == successfulTradeId);
                if (st != null)
                {
                    hunterDB.Remove(st);
                    hunterDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }


        //根据用户偏好及近期收藏内容实现推荐功能
        [HttpGet("recommand")]
        public ActionResult<List<Post>> Recommend(int userId)
        {
            var preferences = hunterDB.Preferences.Where(t => t.UserId == userId);
            try
            {                
                var collects = hunterDB.Collects.Where(t => t.UserId == userId && IsRecentCollect(t.Time));
                int preCount = preferences.Count();
                int collectsCount = collects.Count();

                //存储偏好的类型
                Dictionary<ItemTypes, float> preferencesItemTypesDict = new Dictionary<ItemTypes, float>();
                //存储收藏的帖子中各种类型的占比
                Dictionary<ItemTypes, float> collectsItemTypesDict = new Dictionary<ItemTypes, float>();

                foreach (var p in preferences)
                {
                    preferencesItemTypesDict.Add(p.ItemType,1/(float)preCount);
                }

                foreach (var c in collects)
                {
                    //找到收藏的帖子
                    var post = hunterDB.Posts.FirstOrDefault(t => t.PostId == c.PostId);
                    //如果已经包含该帖子的类型
                    if (collectsItemTypesDict.ContainsKey(post.Type))
                        collectsItemTypesDict[post.Type] += 1 / (float)collectsCount;
                    else
                        collectsItemTypesDict.Add(post.Type, 1/(float)collectsCount);
                }

                //每种类型的推荐数量占比
                Dictionary<ItemTypes, float> recommandDict = new Dictionary<ItemTypes, float>();

                //收藏和偏好权值比例为1：1
                foreach(var c in collectsItemTypesDict)
                {
                    recommandDict.Add(c.Key, c.Value/2);
                }
                foreach(var p in preferencesItemTypesDict)
                {
                    if (recommandDict.ContainsKey(p.Key))
                        recommandDict[p.Key] += p.Value / 2;
                    else
                        recommandDict.Add(p.Key, p.Value);
                }

                List<Post> recommandPosts = new List<Post>();
                foreach (var d in recommandDict)
                {
                    var query = hunterDB.Posts.Where(t => t.Type.ToString() == d.Key.ToString()
                           && t.State.ToString() == "代交易").ToList();
                    //对结果随机排序
                    Random rdm = new Random();
                    List<Post> newQuery = new List<Post>();
                    while (query.Count() > 0)
                    {
                        int index = rdm.Next(query.Count() - 1);
                        newQuery.Add(recommandPosts[index]);
                        query.RemoveAt(index);
                    }
                    //每个分类以10个为基准
                    int count = newQuery.Count();
                    if(10*d.Value>count)
                    {
                        var posts = newQuery.Take(count);
                        foreach (var p in posts)
                            recommandPosts.Add(p);
                    }
                    else
                    {
                        var posts = newQuery.Take(Convert.ToInt32(10 * d.Value));
                        foreach (var p in posts)
                            recommandPosts.Add(p);
                    }

                }
                return recommandPosts;
            }
            catch (Exception e)
            {
                List<ItemTypes> preferencesItemTypes = new List<ItemTypes>();
                List<Post> result = new List<Post>();
                if (preferences != null)
                {
                    foreach (var p in preferences)
                    {
                        preferencesItemTypes.Add(p.ItemType);
                    }
                    foreach (var i in preferencesItemTypes)
                    {
                        var posts = hunterDB.Posts.Where(t => t.Type == i);
                        foreach (var p in posts)
                            result.Add(p);
                    }
                    if (result.Count() > 5)
                        return result.Take(5).ToList();
                    return result.ToList();
                }
                else
                    return hunterDB.Posts.ToList();
            }             
            
        }

        private bool IsRecentCollect(DateTime d)
        {
            //收藏时间
            int year = d.Year;
            int month = d.Month;
            int day = d.Day;
            //当前时间
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            //收藏时间距当前时间的天数
            int days = (currentYear - year) * 365 + (currentMonth - month) * 30 + currentDay - day;
            //按60天内的收藏推荐
            if (days <= 60)
                return true;
            else
                return false;
        }
    }
}
