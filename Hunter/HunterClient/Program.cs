using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinForm;

namespace WinForm
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

            /*
            Console.WriteLine("Hello World!");
            string baseUrl="https://localhost:5001/api/hunter";
            HttpClient client=new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            TodoItem todo=new TodoItem(){Id=50,Name="软件构造基础",IsComplete=false};
            HttpContent content = new StringContent(JsonConvert.SerializeObject(todo), Encoding.UTF8,"application/json");
            var task=client.PostAsync(baseUrl,content);
            task.Wait();
            Console.WriteLine("传送完成");

            var task2 = client.GetStringAsync(baseUrl);
            List<TodoItem> todos = JsonConvert.DeserializeObject<List<TodoItem>>(task2.Result);
            todos.ForEach(t=>Console.WriteLine($"{t.Id},{t.Name},{t.IsComplete}"));
            */
        }

    }
   
}
