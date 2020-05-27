using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

namespace Hunter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_login());

            using (var context = new HunterContext())
            {
                var user = new User();
                user.UserId = "2";
                user.Posts = new List<Post>()
                {
                    new Post() { PostId = "002",UserId="2", Title = "足球" }
                };

                context.Users.Add(user);
                context.SaveChanges();
                Console.WriteLine("插入");
            }

        }

        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "server=localhost;user id=root;password=123456;database=hunter");
            connection.Open();
            return connection;
        }

    }
   
}
