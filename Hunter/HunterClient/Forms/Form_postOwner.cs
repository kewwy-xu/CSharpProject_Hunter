using HunterClient.EntityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunter.Forms
{
    public partial class Form_postOwner : Form
    {
        User user;
        public Form_postOwner(User user)
        {
            this.user = user;
            InitializeComponent();

            tB_regnickname.Text = user.UserName;
            tB_regemail.Text = user.Email;
            tB_regqq.Text = user.QQAccount;
            tB_regwechat.Text = user.WeChatAccount;
            textBox_address.Text = user.CurrentAddress;

        }
    }
}
