using Hunter.Forms;
using HunterClient.Common;
using HunterClient.EntityClass;
using HunterClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterClient.Forms
{
    public partial class Form_main : Form
    { 
        public static User UserNow { get; set; }
        public static Post postNow { get; set; }
        private List<Post> postsNow;

        public Form_main()
        {
            InitializeComponent();
            //推荐
            postsNow = ManagePostsServices.Recommend(UserNow.UserId);
            //postsNow = PostServices.GetAllPosts();

            dataGridView1.DataSource = postsNow;
        }
        

        private void btn_userinfo_Click(object sender, EventArgs e)
        {
            Form_userInfo form = new Form_userInfo(UserNow);
            form.Show();
        }


        //根据按钮名查找分区类型
        public static ItemTypes QueryItemTypeByBtnText(string btnText)
        {
           foreach (ItemTypes t in Enum.GetValues(typeof(ItemTypes)))
            {
                if (btnText== t.ToString())
                {
                    return t;
                }
            }
            return ItemTypes.数码产品;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label_type.Text = button1.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            
            dataGridView1.DataSource = postsNow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_type.Text = button2.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
           
            dataGridView1.DataSource = postsNow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_type.Text = button3.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
           
            dataGridView1.DataSource = postsNow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_type.Text = button4.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            
            dataGridView1.DataSource = postsNow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_type.Text = button5.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            
            dataGridView1.DataSource = postsNow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label_type.Text = button6.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
           
            dataGridView1.DataSource = postsNow;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label_type.Text = button7.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            dataGridView1.DataSource = postsNow;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label_type.Text = button8.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            dataGridView1.DataSource = postsNow;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label_type.Text = button10.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            dataGridView1.DataSource = postsNow;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label_type.Text = button11.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            dataGridView1.DataSource = postsNow;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label_type.Text = button12.Text;
            ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
            postsNow = PostServices.QueryByItemType(itemType);
            dataGridView1.DataSource = postsNow;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.ColumnIndex;
            string str = dataGridView1.Rows[e.RowIndex].Cells["PostId"].Value.ToString();
            int postId = Convert.ToInt32(str);
            postNow = PostServices.GetPostByPostId(postId);

            if (index == 5) //查看详情
            {                
                Form_postDetail form = new Form_postDetail(postNow);
                form.Show();
            }
            else if (index == 6)//收藏
            {
                //已经收藏
                if(ManagePostsServices.GetCollectByUserIdAndPostId(UserNow.UserId, postNow.PostId)!=0)
                {
                    MessageBox.Show("已收藏过该帖子！");
                    return;
                }
                //未收藏
                Collect c = new Collect(postNow.PostId, UserNow.UserId, DateTime.Now);
                ManagePostsServices.Collect(c);
                MessageBox.Show("收藏成功！");
            }
        }

        private void btn_addPost_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(UserNow);
            frm3.Show();
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            
            if (textBox_minPrice.Text == "" || textBox_maxPrice.Text == "")
            { MessageBox.Show("价格区间不能为空！"); return; }
            if(dateTimePicker_begin.Value.ToString()==""|| dateTimePicker_end.Value.ToString()=="")
            { MessageBox.Show("时间区间不能为空！"); return; }

            
            //搜索
            if (textBox_searchInput.Text != "")
            {
                if (label_type.Text != "全部")
                    postsNow = PostServices.QueryByKeyword(textBox_searchInput.Text).
                        Where(t => t.Type.ToString() == label_type.Text).ToList();
                else
                    postsNow = PostServices.QueryByKeyword(textBox_searchInput.Text);

            }
            //筛选
            postsNow = PostServices.ScreenByTime(dateTimePicker_begin.Value,
                dateTimePicker_end.Value, postsNow);

            postsNow = PostServices.ScreenByPrice(Convert.ToSingle(textBox_minPrice.Text),
                Convert.ToSingle(textBox_maxPrice.Text), postsNow);
                
            postsNow = PostServices.OrderByTimeAndPrice(comboBox_timeOrder.Text,
                comboBox_priceOrder.Text, postsNow);

   
            postsNow = postsNow.Where(p => p.PostType.ToString() == comboBox_postType.Text.ToString()).ToList();
            dataGridView1.DataSource = postsNow;
            //还原
            if (label_type.Text == "全部")
                postsNow = PostServices.GetAllPosts();
            else
            {
                ItemTypes itemType = QueryItemTypeByBtnText(label_type.Text);
                postsNow = PostServices.QueryByItemType(itemType);
            }
            
        }

        private void btn_allPosts_Click(object sender, EventArgs e)
        {
            label_type.Text = "全部";
            postsNow = PostServices.GetAllPosts();
            dataGridView1.DataSource = postsNow;
        }
    }
}
