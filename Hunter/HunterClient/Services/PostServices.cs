using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterClient.EntityClass;
using HunterClient.Common;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using HunterClient.Forms;

namespace HunterClient.Services
{
    public class PostServices
    {        
        //发帖
        public static bool AddPost(Post post)
        {
            string strUser = "https://localhost:5001/api/hunter/post/addPost?";
            HttpClient client1 = new HttpClient();
            client1.DefaultRequestHeaders.Accept.Clear();
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(post),
                Encoding.UTF8, "application/json");
            var task = client1.PostAsync(strUser, content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }
        //删帖
        public static void DeletePost(int userId, int postId)
        {
            string strUser = "https://localhost:5001/api/hunter/post/deletePost?" +
                "userId=" + userId + "&&postId=" + postId;
            HttpClient client = new HttpClient();

            var task = client.DeleteAsync(strUser);
            task.Wait();
            return;
        }

        //修改帖子内容
        public static void AlterPost(int userId, int postId, string title,
            string description, ItemTypes type, PostTypes postType,float price)
        {
            string strUser = "https://localhost:5001/api/hunter/post/alterPost?" +
                "postId=" + postId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Post post = new Post(postId);
            post.Title = title;
            post.UserId = userId;
            post.Type = type;
            post.PostType = postType;
            post.BriefDescription = description;
            post.Price = price;


            HttpContent content = new StringContent(JsonConvert.SerializeObject(post),
                Encoding.UTF8, "application/json");
            var task = client.PutAsync(strUser, content);
            // Post user1 = JsonConvert.DeserializeObject<Post>(task.Result.ToString());

            task.Wait();
            return;
        }

        //修改帖子的状态
        public static void AlterPostState(int userId, int postId, States state)
        {

            string strUser = "https://localhost:5001/api/hunter/post/alterPost?" +
                "postId=" + postId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Post post = new Post(postId);
            post.UserId = userId;
            post.State = state;


            HttpContent content = new StringContent(JsonConvert.SerializeObject(post),
                Encoding.UTF8, "application/json");
            var task = client.PostAsync(strUser, content);
            task.Wait();
            return;
        }
        //跟据userId查询用户收藏的帖子
        public static List<int> GetCollectsByUserId(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/post/getCollectsByUserId?userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            var postIds = JsonConvert.DeserializeObject<List<int>>(task2.Result);
            return postIds;
        }
        
        //按postId查询帖子
        public static Post GetPostByPostId(int postId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/post/getPostByPostId?postId=" + postId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            Post post = JsonConvert.DeserializeObject<Post>(task2.Result);

            MemoryStream ms = new MemoryStream(post.imageByte);

            post.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
            ms.Close();

            return post;
        }
        //按userId搜索用户的帖子
        public static List<Post> GetUserPosts(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/post/getUserPosts?userid=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(task2.Result);

            foreach (var p in posts)
            {
                MemoryStream ms = new MemoryStream(p.imageByte);

                p.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();

            }

            return posts;
        }
        
        //查找全部帖子
        public static List<Post> GetAllPosts()
        {
            string baseUrl = "https://localhost:5001/api/hunter/post";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(task2.Result);

            foreach (var p in posts)
            {
                MemoryStream ms = new MemoryStream(p.imageByte);

                p.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();
            }
            return posts;
        }

        //按分类查询
        public static List<Post> QueryByItemType(ItemTypes itemType)
        {
            string baseUrl = "https://localhost:5001/api/hunter/post/queryByItemType?"
                + "itemType=" + itemType.ToString();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(task2.Result);

            foreach (var p in posts)
            {
                MemoryStream ms = new MemoryStream(p.imageByte);

                p.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();

            }

            return posts;
        }
        //按关键字搜索全部
        public static List<Post> QueryByKeyword(string keyword)
        {
            string baseUrl = "https://localhost:5001/api/hunter/post/queryByKeyword?"
                + "keyword=" + keyword;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task2 = client.GetStringAsync(baseUrl);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(task2.Result);

            foreach (var p in posts)
            {
                MemoryStream ms = new MemoryStream(p.imageByte);

                p.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();

            }

            return posts;
        }
        

        //按价格筛选
        public static List<Post> ScreenByPrice(float beginPrice,
            float endPrice, List<Post> posts)
        {
            return posts.Where(p => p.Price >= beginPrice && p.Price <= endPrice).ToList();
        }

        //按时间筛选
        public static List<Post> ScreenByTime(DateTime beginTime,
            DateTime endTime, List<Post> posts)
        {
            return posts.Where(p => p.Time >= beginTime && p.Time <= endTime).ToList();
        }

        //按时间和价格升降排序
        public static List<Post> OrderByTimeAndPrice(string timeOrder,
            string priceOrder, List<Post> posts)
        {
            if (timeOrder == "按时间升序" && priceOrder == "按价格升序")
            {
                return posts
                   .OrderBy(s => s.Time)
                   .OrderBy(t => t.Price)
                   .ToList();
            }
            else if (timeOrder == "按时间升序" && priceOrder == "按价格降序")
            {
                return posts
                    .OrderBy(s => s.Time)
                    .OrderByDescending(t => t.Price)
                    .ToList();
            }
            else if (timeOrder == "按时间降序" && priceOrder == "按价格升序")
            {
                return posts
                    .OrderByDescending(s => s.Time)
                    .OrderBy(t => t.Price)
                    .ToList();
            }
            else
            {
                return posts
                    .OrderByDescending(s => s.Time)
                    .OrderByDescending(t => t.Price)
                    .ToList();
            }
        }

    }
}
