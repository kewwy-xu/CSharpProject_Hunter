using HunterClient.EntityClass;
using HunterClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterClient.Forms
{
    public partial class Form_verify : Form
    {
        public static User userNow;

        public Form_verify()
        {
            InitializeComponent();
        }
        //定义一个全局的string类型的验证码        
        string code = "";
        //定义一个字符创，里面包含所需要的验证码元素        
        string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //定义一个时间，用于倒计时        
        int time;
        private void button_post_Click(object sender, EventArgs e)
        {
            var user = UserServices.VerifyEmail(textBox_email.Text);
            if (user!=null)
            {
                Form_verify.userNow = user;
                //实例化一个随机数            
                Random b = new Random();
                //循环6次得到一个随机的六位数的验证码            
                for (int i = 0; i < 6; i++)
                {
                    code = code + a.Substring(b.Next(0, a.Length), 1);
                }
                //创建服务器对象            
                SmtpClient smtp = new SmtpClient("smtp.qq.com");
                //创建邮件对象准备发送            
                MailAddress mail1 = new MailAddress("1847252712@qq.com");
                //获取文本框的收件人的邮箱                                
                MailAddress mail2 = new MailAddress(textBox_email.Text);


                //创建邮件对象，准备发送【mail1是发件人地址，mail2是收件人地址】               
                MailMessage mess = new MailMessage(mail1, mail2);
                //邮件的标题                
                mess.Subject = "邮件验证码";
                //邮件的内容                
                mess.Body = "您的验证码为" + code + ",请在30分钟内验证，系统邮件请勿回复！";
                //创建互联网安全证书                
                NetworkCredential cred =
                    new NetworkCredential("1847252712@qq.com", "bstrayrbqeaubjch");
                //证书绑定到服务器对象以便服务器验证                
                smtp.Credentials = cred;
                //开始发送                
                smtp.Send(mess);
                //发送完成后按钮不可用                
                button_post.Enabled = false;
                //激活timer事件                
                timer1.Enabled = true;
                //倒计时100秒                
                time = 100;
                MessageBox.Show("发送成功");
            }
            else
            {
                MessageBox.Show("该邮箱不存在，请重新输入！");
            }

        }

        private void button_test_Click(object sender, EventArgs e)
        {
          
            if (code == textBox_test.Text)
            {
                Form_main.UserNow = Form_verify.userNow;

                Thread th = new Thread(delegate () { new Form_main().ShowDialog(); });
                th.Start();
                this.Close();
                //MessageBox.Show("正确");
            }
            else
            {
                MessageBox.Show("验证码错误！");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            button_post.Text = "time";
            if (time <= 0)
            {
                button_post.Text = "发送";
                timer1.Enabled = false;
                button_post.Enabled = true;
            }
        }
    }
}
