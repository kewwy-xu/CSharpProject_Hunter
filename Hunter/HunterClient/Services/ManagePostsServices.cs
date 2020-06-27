using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HunterClient.Common;
using HunterClient.EntityClass;
using HunterClient.Forms;
using Newtonsoft.Json;

namespace HunterClient.Services
{
    public class ManagePostsServices
    {
        //举报帖子,管理员处理
        public static void TipOffPost(int postId)
        {
            
        }

        //举报评论，管理员处理
        public static void TipOffComment(Comment comment)
        {

        }

        //发表评论
        public static void IssueComment(Comment comment)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/issueComment?comment=" + comment;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(JsonConvert.SerializeObject(comment), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }

        //删除评论
        public static void DeleteComment(int commentId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/deleteComment?"+
                 "commentId=" + commentId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.DeleteAsync(baseUrl);
            task.Wait();
        }

        //根据postId查找全部评论
        public static List<Comment> QueryCommentsByPostId(int postId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/queryCommentsByPostId?" +
                "postId=" + postId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            var commentsList= JsonConvert.DeserializeObject<List<Comment>>(task.Result);
            return commentsList;
        }

        //查看我的评论
        public static List<Comment> QueryMyComments(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/QueryMyComments?" +
                "userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            var commentsList = JsonConvert.DeserializeObject<List<Comment>>(task.Result);
            return commentsList;
        }

        //根据userId和postId查找收藏Id
        public static int GetCollectByUserIdAndPostId(int userId,int postId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/getCollectByUserIdAndPostId?" +
                "userId=" + userId + "&&postId=" + postId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            var collectId = JsonConvert.DeserializeObject<int>(task.Result);
            return collectId;
        }
        //收藏
        public static void Collect(Collect c)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/collect?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
          
            HttpContent content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait(); 
        }
        //取消收藏
        public static void DeleteCollect(int collectId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/deleteCollect?collectId=" + collectId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.DeleteAsync(baseUrl);
            task.Wait();
        }


        //记录交易成功的帖子
        public static void RecordSuccessfulTrade(SuccessfulTrade st)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/recordSuccessfulTrade?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(JsonConvert.SerializeObject(st), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }
        //删除交易成功的帖子
        public static void DeleteSuccessfulTrade(int successfulTradeId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/deleteSuccessfulTrade?" +
                "successfulTradeId=" + successfulTradeId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.DeleteAsync(baseUrl);
            task.Wait();
        }


        //根据用户偏好及近期收藏内容实现推荐功能
        public static List<Post> Recommend(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/managePosts/recommand?userId="+userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(task.Result);

            foreach (var p in posts)
            {
                MemoryStream ms = new MemoryStream(p.imageByte);

                p.Image = Form3.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();

            }
            return posts;
        }
    }
}
