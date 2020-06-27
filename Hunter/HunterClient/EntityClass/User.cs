using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using HunterClient.Common;

namespace HunterClient.EntityClass
{
    public class User 
    {
        public int UserId { set; get; }

        public string UserName { set; get; }

        public DateTime RegTime { set; get; }

        public string CurrentAddress { set; get; }

        public string Password { get; set; }

        public List<Post> Posts { set; get; }

        public List<Post> SuccessfulTrades { set; get; }

        public List<Post> Favorites { set; get; }

        public List<ItemTypes> Preferences { set; get; }

        public string QQAccount { set; get; }

        public string WeChatAccount { set; get; }

        public string Email { set; get; }

        public bool Authority { get; set; }               //管理员权限

        public Post Post
        {
            get => default;
            set
            {
            }
        }

        public Hunter.EntityClass.Preference Preference
        {
            get => default;
            set
            {
            }
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
