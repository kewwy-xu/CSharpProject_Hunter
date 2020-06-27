using HunterClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HunterClient.EntityClass;
using Hunter.Forms;
using System.Threading;
using Hunter.EntityClass;
using HunterClient.Common;

namespace HunterClient.Forms
{
    public partial class Form_userInfo : Form
    {
        Post postNow;
        List<Post> postsNow;
        User user;
        public Form_userInfo(User user)
        {
            InitializeComponent();
            this.user = user;
            tB_regnickname.Text = user.UserName;
            tB_regemail.Text = user.Email;
            tB_regqq.Text = user.QQAccount;
            tB_regwechat.Text = user.WeChatAccount;
            tB_regpassword1.Text = user.Password;
            tB_regpassword2.Text = user.Password;
            textBox_address.Text = user.CurrentAddress;
            //偏好
            
            postsNow = PostServices.GetUserPosts(user.UserId);
            dataGridView1.DataSource = postsNow;
        }     

        private void btn_userinfochange_Click(object sender, EventArgs e)
        {
            if (tB_regpassword1.Text != tB_regpassword2.Text)
            {
                MessageBox.Show("两次密码输入不一致！");
            }
            else 
            {
                User userchange = new User(tB_regnickname.Text, tB_regpassword1.Text, tB_regemail.Text);
                userchange.UserId = Form_main.UserNow.UserId;
                userchange.QQAccount = tB_regqq.Text;
                userchange.WeChatAccount = tB_regwechat.Text;
                userchange.CurrentAddress = textBox_address.Text;

                //偏好
                var pre = checkedListBox1.CheckedItems;
                foreach(var p in pre)
                {
                    var itemType = Form_main.QueryItemTypeByBtnText(p.ToString());
                    Preference pref = new Preference(Form_main.UserNow.UserId, itemType);
                    UserServices.ChoosePreferences(pref);
                }

                UserServices.AlterPersonalInfo(userchange.UserId, userchange);
                MessageBox.Show("修改成功！");
            }
            
        }

        private void btn_myPosts_Click(object sender, EventArgs e)
        {
            label_myPostsOrCollects.Text = "我的帖子";
            dataGridView1.Columns["btn_alter"].Visible = true;
            postsNow = PostServices.GetUserPosts(user.UserId);
            dataGridView1.DataSource = postsNow;
        }

        private void btn_collects_Click(object sender, EventArgs e)
        {
            label_myPostsOrCollects.Text = "收藏";
            dataGridView1.Columns["btn_alter"].Visible = false;
            var postIds = PostServices.GetCollectsByUserId(user.UserId);
            List<Post> newPostsNow = new List<Post>();
            foreach(var p in postIds)
            {
                Post post = PostServices.GetPostByPostId(p);
                newPostsNow.Add(post);
            }
            postsNow = newPostsNow;
            dataGridView1.DataSource = postsNow;
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (textBox_minPrice.Text == "" || textBox_maxPrice.Text == "")
            { MessageBox.Show("价格区间不能为空！"); return; }
            if (dateTimePicker_begin.Value.ToString() == "" || dateTimePicker_end.Value.ToString() == "")
            { MessageBox.Show("时间区间不能为空！"); return; }

            if (label_myPostsOrCollects.Text == "我的帖子")
                postsNow = PostServices.GetUserPosts(user.UserId);
            else
            {
                List<Post> newPostsNow = new List<Post>();
                var postIds = PostServices.GetCollectsByUserId(user.UserId);
                foreach (var p in postIds)
                {
                    Post post = PostServices.GetPostByPostId(p);
                    newPostsNow.Add(post);
                }
                postsNow = newPostsNow;
            }

            if(textBox_searchInput.Text!="")
                postsNow = PostServices.QueryByKeyword(textBox_searchInput.Text);

            postsNow = PostServices.ScreenByTime(dateTimePicker_begin.Value,
                dateTimePicker_end.Value, postsNow);

            postsNow = PostServices.ScreenByPrice(Convert.ToSingle(textBox_minPrice.Text),
                Convert.ToSingle(textBox_maxPrice.Text), postsNow);

            postsNow = PostServices.OrderByTimeAndPrice(comboBox_timeOrder.Text,
                comboBox_priceOrder.Text, postsNow);

 
            postsNow = postsNow.Where(p => p.PostType.ToString() == comboBox_postType.ToString()).ToList();
            dataGridView1.DataSource = postsNow;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;

            string str = dataGridView1.Rows[e.RowIndex].Cells["PostId"].Value.ToString();
            int postId = Convert.ToInt32(str);
            postNow = PostServices.GetPostByPostId(postId);

            if (index==7) //查看详情
            {                
                Form_postDetail form = new Form_postDetail(postNow);
                form.Show();
            }         
            else if(index==8)//删除
            {
                if (label_myPostsOrCollects.Text == "收藏")
                {
                    int collectId = ManagePostsServices.GetCollectByUserIdAndPostId(user.UserId, postId);
                    ManagePostsServices.DeleteCollect(collectId);
                    MessageBox.Show("取消收藏成功！");
                }
                else  //我的帖子
                {
                    PostServices.DeletePost(user.UserId, postId);
                    MessageBox.Show("删除成功！");
                }
            }
            else if (index==9)//修改
            {

            }
        }
    }
}
