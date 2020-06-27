using HunterClient.EntityClass;
using HunterClient.Forms;
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

namespace Hunter.Forms
{
    public partial class Form_postDetail : Form
    {
        List<Comment> comments;
        Post post;
        public static Image imageClick;
        public Form_postDetail(Post post)
        {
            InitializeComponent();
            this.post = post;
            //帖子信息
            textBox_title.Text = post.Title;
            textBox_time.Text = post.Time.ToString();
            textBox_type.Text = post.Type.ToString();
            textBox_postType.Text = post.PostType.ToString();
            richTextBox_description.Text = post.BriefDescription;
            pictureBox.Image = post.Image;
            
            //评论
            comments = ManagePostsServices.QueryCommentsByPostId(post.PostId);
            dataGridView1.DataSource = comments;
        }

        private void button_comment_Click(object sender, EventArgs e)
        {
            Comment c = new Comment(richTextBox_comment.Text, post.PostId,
                Form_main.UserNow.UserId,Form_main.UserNow.UserName);
            ManagePostsServices.IssueComment(c);
            richTextBox_comment.Text = "";

            comments = ManagePostsServices.QueryCommentsByPostId(post.PostId);
            dataGridView1.DataSource = comments;
        }

        

        private void pictureBox_Click(object sender, EventArgs e)
        {
            imageClick = pictureBox.Image;

            Form_imageClick form = new Form_imageClick();
            form.Show();
        }

        private void btn_lookPostOwner_Click(object sender, EventArgs e)
        {
            User user = UserServices.GetUserInfoByUserId(post.UserId);
            Form_postOwner form = new Form_postOwner(user);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            string userIdStr = dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
            int commentOwnerUserId = Convert.ToInt32(userIdStr);

            string commentIdStr= dataGridView1.Rows[e.RowIndex].Cells["CommentId"].Value.ToString();
            int commentId = Convert.ToInt32(commentIdStr);

            if (index==3)//删除
            {
                //本人或管理员
                if(Form_main.UserNow.UserId==commentOwnerUserId||
                    Form_main.UserNow.Authority==true)
                {
                    ManagePostsServices.DeleteComment(commentId);
                    comments = ManagePostsServices.QueryCommentsByPostId(post.PostId);
                    dataGridView1.DataSource = comments;
                }
            }
            else if(index==4)//举报
            {

            }
        }
    }
}
