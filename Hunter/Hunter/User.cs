using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace Hunter
{
    internal class User : IComparable<User>
    {
        public string UserId { set; get; }

        public string NickName { set; get; }

        public DateTime RegTime { set; get; }

        public string CurrentAddress { set; get; }

        private string Password;

        public List<Post> Posts { set; get; }

        public List<Post> SuccessfulTrades { set; get; }

        public List<Post> Favorites { set; get; }

        public List<string> Preferences { set; get; }

        public string QQAccount { set; get; }

        public string WeChatAccount { set; get; }

        public string Email { set; get; }

        private bool Authority;                  //管理员权限


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
            UserId = Guid.NewGuid().ToString();
            Posts = new List<Post>();
            SuccessfulTrades = new List<Post>();
            Favorites = new List<Post>();
            Preferences = new List<string>();
            RegTime = DateTime.Now;
            Authority = false;
        }

        public User(string nickname, string password,string email,string qqaccount,string wechataccount) : this()
        {
            this.NickName = nickname;
            this.Password = password;
            this.Email = email;
            this.QQAccount = qqaccount;
            this.WeChatAccount = wechataccount;
        }

        public override bool Equals(object obj)
        {
            var order = obj as User;
            return order != null &&
                   UserId == order.UserId;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{UserId}, NickName:{NickName},RegTime:{RegTime},Email：{Email}");
            return strBuilder.ToString();
        }

        public int CompareTo(User other)
        {
            if (other == null) return 1;
            return this.UserId.CompareTo(other.UserId);
        }

      
        
    }
}
