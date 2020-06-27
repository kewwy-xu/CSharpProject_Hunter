using HunterClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterClient.Forms
{
    public partial class Form_reg : Form
    {
        public Form_reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string TextMatch =
                "^[a-z0-9A-Z]+[- | a-z0-9A-Z . _]+@([a-z0-9A-Z]+(-[a-z0-9A-Z]+)?\\.)+[a-z]{2,}$";
            if (tB_regnickname.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else if (tB_regpassword1.Text == "")
            {
                MessageBox.Show("密码不能为空！");
            }
            else if (tB_regemail.Text == "")
            {
                MessageBox.Show("邮箱不能为空！");
            }
            else if (tB_regpassword1.Text != tB_regpassword2.Text)
            {
                MessageBox.Show("两次密码输入不一致！");
            }
            else if (Regex.IsMatch(tB_regemail.Text, TextMatch) == false)
            {
                MessageBox.Show("邮箱格式错误！");
            }
            else if (UserServices.Register(tB_regnickname.Text, tB_regpassword1.Text, tB_regemail.Text, tB_regqq.Text, tB_regwechat.Text) == false)
            {               
                MessageBox.Show("用户名或邮箱已被使用！");
            }
            else
            {
                //MessageBox.Show("注册成功！");
                Thread th = new Thread(delegate () { new Form_login().ShowDialog(); });
                th.Start();
                this.Close();
            }
                
        }

        private void btn_regtologin_Click(object sender, EventArgs e)
        {

        }
    }
}
