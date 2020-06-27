using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace HunterApi.Models
{
    public class User
    {
        public int UserId { set; get; }

        public string UserName { set; get; }

        public DateTime RegTime { set; get; }

        public string CurrentAddress { set; get; }

        public string Password { get; set; }
        
        public string QQAccount { set; get; }

        public string WeChatAccount { set; get; }

        public string Email { set; get; }

        public bool Authority { get; set; }               //管理员权限
        

        public void Register() { }

        public void Login() { }

        public void Logout() { }

        public void Signout() { }

        public void AlterPassword() { }

        public void AddPost() { }

        public void QuerySelfByKeyWord() { }

        public void QuerySelfByLabel() { }

        public void DeletePost() { }

        public void AlterPost() { }

        public void Comment() { }

        public void TipOff() { }

        public void Collect() { }

        public void RecordSuccessfulTrades() { }

        public User()
        {

        }
        //注册
        public User(string userName, string password,string email)
        {
            RegTime = DateTime.Now;
            Authority = false;
            Password = password;
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        
    }
}
