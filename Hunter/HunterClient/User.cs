using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace WinForm
{
    public class User : IComparable<User>
    {
        public int UserId { set; get; }

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

        //注册
        public User(string nickName, string password,string email)
        {
            RegTime = DateTime.Now;
            Authority = false;
            NickName = nickName ?? throw new ArgumentNullException(nameof(nickName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
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
