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
    public delegate void AppendString(string strText);
    public partial class Form3 : Form
    {
        User user = null;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

         

        private void btnPost_Click(object sender, EventArgs e)
        {
            
            //将图片以文件流的形式进行保存
            FileStream fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length); //将流读入到字节数组中
            
            Post post = new Post(this.user.UserId, this.txtTitle.Text.Trim(), this.txtDescribe.Text.Trim(),
                (float)Convert.ToDouble(this.txtPrice.Text.Trim()), DateTime.Now, (Common.ItemTypes)cmbType.SelectedIndex,
                (Common.PostTypes)cmbPostType.SelectedIndex, States.待交易,imgBytesIn);

            bool blnRe = PostServices.AddPost(post);

            
            if(blnRe)
            {
                MessageBox.Show("发帖成功！");
            }
            else
            {
                MessageBox.Show("发帖失败！");
            }
        }

        string strPath = string.Empty;

        private void btnPath_Click(object sender, EventArgs e)
        {
            //{ }
            //    this.txtPath.Text = file.FileName;
            //    Bitmap bitMap = new Bitmap(this.txtPath.Text);
            //    if (this.pictureBox2.BackgroundImage != null)
            //    {
            //        this.pictureBox2.BackgroundImage.Dispose();
            //        this.pictureBox2.BackgroundImage = null;
            //    }
            //    this.pictureBox2.BackgroundImage = bitMap;
            //    this.pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            //} 
            Thread thGetPath = new Thread(new ThreadStart(GetPicturePath));
            thGetPath.SetApartmentState(ApartmentState.STA);
            thGetPath.IsBackground = true;
            thGetPath.Start();

        }

        private void AppendString(string strText)
        {
            if(this.txtPath.InvokeRequired)
            {
                this.txtPath.BeginInvoke(new AppendString(AppendString), new object[] { strText });
            }
            else
            {
                this.txtPath.Text = strText;
            }
        }

        private void GetPicturePath()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "图片文件|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                strPath = file.FileName;

                AppendString(strPath);
            }
        }


        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Bitmap bitMap = new Bitmap(this.txtPath.Text);
            if (this.pictureBox2.BackgroundImage != null)
            {
                this.pictureBox2.BackgroundImage.Dispose();
                this.pictureBox2.BackgroundImage = null;
            }
            Image image = ResizeImage(bitMap, new Size(280, 280));
            this.pictureBox2.BackgroundImage = image;
            pictureBox2.Size = new Size(280, 280);
            this.pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            
            bitMap.Dispose();
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;
        }

      
    }
}
