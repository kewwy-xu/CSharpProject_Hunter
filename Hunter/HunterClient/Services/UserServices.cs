using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Hunter.EntityClass;
using HunterClient.Common;
using HunterClient.EntityClass;
using Newtonsoft.Json;

namespace HunterClient.Services
{
    public class UserServices
    {
        //注册
        public static bool Register(string userName, string password,
             string emailAddress,string? QQ,string? WeChat)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/register?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            User user_reg = new User(userName, password, emailAddress);
            user_reg.QQAccount = QQ;
            user_reg.WeChatAccount = WeChat;
            HttpContent content = new StringContent(JsonConvert.SerializeObject(user_reg), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }
        //通过邮箱或用户名登录
        public static int Login(string userNameOrEmailAddress, string password)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/login?" +
                "userNameOrEmailAddress=" + userNameOrEmailAddress + "&&password=" + password;
            HttpClient client = new HttpClient();

            var task = client.GetStringAsync(baseUrl);
            return Convert.ToInt32(task.Result);
        }

        //邮箱验证
        public static User VerifyEmail(string EmailAddress)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/email?"
                + "EmailAddress=" + EmailAddress;

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<User>(task.Result);
        }
        //通过userId查询用户信息
        public static User GetUserInfoByUserId(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/getUserInfoByUserId?" +
                "userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            User user = JsonConvert.DeserializeObject<User>(task.Result);
            return user;
        }

        //通过用户名查询用户信息
        public static User GetUserInfoByUserName(string userName)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/getUserInfoByUserName?" +
                "userName=" + userName;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            User user = JsonConvert.DeserializeObject<User>(task.Result);
            return user;
        }

        //修改个人中心显示出来的个人信息
        public static void AlterPersonalInfo(int userId, User user)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/alterPersonalInfo?" + "userId="+ userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
           // User user1 = JsonConvert.DeserializeObject<User>(task.Result.ToString());
           
        }


        //选择偏好
        public static void ChoosePreferences(Preference preference)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/choosePreferences?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(preference), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }
        
        public static List<ItemTypes> GetUserPreferences(int userId)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/getUserPreferences?" +
                "userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            return JsonConvert.DeserializeObject<List<ItemTypes>>(task.Result);
        }

        
    }
}
