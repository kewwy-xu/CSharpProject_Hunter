namespace HunterClient.Forms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbPostType = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lable23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "发帖";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.cmbPostType);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtDescribe);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lable23);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 753);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(731, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 363);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.SystemColors.Info;
            this.btnPath.Location = new System.Drawing.Point(660, 181);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(64, 31);
            this.btnPath.TabIndex = 27;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.Info;
            this.btnPost.Font = new System.Drawing.Font("黑体", 19F);
            this.btnPost.Location = new System.Drawing.Point(500, 602);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(163, 78);
            this.btnPost.TabIndex = 27;
            this.btnPost.Text = "发帖";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtPath
            // 
            this.txtPath.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtPath.BackColor = System.Drawing.Color.SeaShell;
            this.txtPath.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPath.Location = new System.Drawing.Point(731, 135);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(371, 40);
            this.txtPath.TabIndex = 24;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.SeaShell;
            this.txtPrice.Font = new System.Drawing.Font("黑体", 10F);
            this.txtPrice.Location = new System.Drawing.Point(218, 503);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 41);
            this.txtPrice.TabIndex = 24;
            // 
            // cmbPostType
            // 
            this.cmbPostType.BackColor = System.Drawing.Color.SeaShell;
            this.cmbPostType.FormattingEnabled = true;
            this.cmbPostType.Items.AddRange(new object[] {
            "出售",
            "收购"});
            this.cmbPostType.Location = new System.Drawing.Point(218, 422);
            this.cmbPostType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPostType.Name = "cmbPostType";
            this.cmbPostType.Size = new System.Drawing.Size(163, 23);
            this.cmbPostType.TabIndex = 22;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.SeaShell;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "手机数码",
            "家用电器",
            "运动户外",
            "衣鞋帽伞",
            "书籍",
            "游戏装备",
            "房屋租凭",
            "健身器材",
            "其它"});
            this.cmbType.Location = new System.Drawing.Point(218, 334);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(163, 23);
            this.cmbType.TabIndex = 21;
            // 
            // txtDescribe
            // 
            this.txtDescribe.BackColor = System.Drawing.Color.SeaShell;
            this.txtDescribe.Font = new System.Drawing.Font("黑体", 10F);
            this.txtDescribe.Location = new System.Drawing.Point(218, 228);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(335, 41);
            this.txtDescribe.TabIndex = 20;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.SeaShell;
            this.txtTitle.Font = new System.Drawing.Font("黑体", 10F);
            this.txtTitle.Location = new System.Drawing.Point(218, 135);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(335, 41);
            this.txtTitle.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(672, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "图片";
            // 
            // lable23
            // 
            this.lable23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable23.Location = new System.Drawing.Point(116, 503);
            this.lable23.Name = "lable23";
            this.lable23.Size = new System.Drawing.Size(65, 41);
            this.lable23.TabIndex = 18;
            this.lable23.Text = "价格";
            this.lable23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(129, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "分类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(89, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "发帖类型";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(129, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 41);
            this.label3.TabIndex = 15;
            this.label3.Text = "描述";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(129, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "标题";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(432, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "请输入商品信息";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lable23;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbPostType;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}