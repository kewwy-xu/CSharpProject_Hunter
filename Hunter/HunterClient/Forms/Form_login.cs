using HunterClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterClient.Forms
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();            
        }

        private void linkLab_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
            Thread th = new Thread(delegate () { new Form_reg().ShowDialog(); });
            th.Start();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tB_nickname.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else if (tB_password.Text == "")
            {
                MessageBox.Show("密码不能为空！");
            }

            int result_log = UserServices.Login(tB_nickname.Text, tB_password.Text);

            if (result_log == 0)
            {
                MessageBox.Show("用户不存在！");
            }
            else if (result_log == -1)
            {
                MessageBox.Show("密码错误！");
            }
            else if (result_log == 1)
            {
                Form_main.UserNow = UserServices.GetUserInfoByUserName(tB_nickname.Text);

                Thread th = new Thread(delegate () { new Form_main().ShowDialog(); });
                th.Start();
                this.Close();

                //MessageBox.Show("登录成功!");
            }
        }

        private void link_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread th = new Thread(delegate () { new Form_verify().ShowDialog(); });
            th.Start();
            this.Close();          
        }
    }
    public class TextBoxEx : TextBox
    {
        private const int WM_PAINT = 0x000F;

        private string backGroundText = "";

        [Description("BackGround Text")]
        public string BackGroundText
        {
            get { return backGroundText; }
            set { backGroundText = value; }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (Graphics g = CreateGraphics())
                {
                    if (string.IsNullOrEmpty(Text) && !Focused)
                    {
                        SizeF size = g.MeasureString(backGroundText, Font);
                        //draw background text
                        g.DrawString(backGroundText, Font, Brushes.LightGray, new PointF(0, (Height - size.Height) / 2));
                    }
                }
            }
        }
    }
}
