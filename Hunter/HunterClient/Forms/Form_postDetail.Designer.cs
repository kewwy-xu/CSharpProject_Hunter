namespace Hunter.Forms
{
    partial class Form_postDetail
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_postType = new System.Windows.Forms.TextBox();
            this.btn_comment = new System.Windows.Forms.Panel();
            this.btn_lookPostOwner = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox_comment = new System.Windows.Forms.RichTextBox();
            this.button_comment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentContextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteComment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tipOffComment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CommentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(25, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "发帖时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "所属分区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "帖子类型";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox_description.Location = new System.Drawing.Point(17, 275);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.Size = new System.Drawing.Size(405, 103);
            this.richTextBox_description.TabIndex = 8;
            this.richTextBox_description.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(46, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "照片";
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_title.Location = new System.Drawing.Point(136, 31);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.ReadOnly = true;
            this.textBox_title.Size = new System.Drawing.Size(145, 25);
            this.textBox_title.TabIndex = 14;
            // 
            // textBox_type
            // 
            this.textBox_type.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_type.Location = new System.Drawing.Point(136, 140);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.ReadOnly = true;
            this.textBox_type.Size = new System.Drawing.Size(145, 25);
            this.textBox_type.TabIndex = 15;
            // 
            // textBox_time
            // 
            this.textBox_time.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_time.Location = new System.Drawing.Point(136, 89);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.ReadOnly = true;
            this.textBox_time.Size = new System.Drawing.Size(145, 25);
            this.textBox_time.TabIndex = 16;
            // 
            // textBox_postType
            // 
            this.textBox_postType.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_postType.Location = new System.Drawing.Point(136, 192);
            this.textBox_postType.Name = "textBox_postType";
            this.textBox_postType.ReadOnly = true;
            this.textBox_postType.Size = new System.Drawing.Size(145, 25);
            this.textBox_postType.TabIndex = 17;
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.Beige;
            this.btn_comment.Controls.Add(this.btn_lookPostOwner);
            this.btn_comment.Controls.Add(this.label1);
            this.btn_comment.Controls.Add(this.textBox_postType);
            this.btn_comment.Controls.Add(this.textBox_title);
            this.btn_comment.Controls.Add(this.pictureBox);
            this.btn_comment.Controls.Add(this.textBox_type);
            this.btn_comment.Controls.Add(this.label9);
            this.btn_comment.Controls.Add(this.textBox_time);
            this.btn_comment.Controls.Add(this.richTextBox_description);
            this.btn_comment.Controls.Add(this.label3);
            this.btn_comment.Controls.Add(this.label2);
            this.btn_comment.Controls.Add(this.label4);
            this.btn_comment.Controls.Add(this.label5);
            this.btn_comment.Location = new System.Drawing.Point(12, 12);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(427, 729);
            this.btn_comment.TabIndex = 18;
            // 
            // btn_lookPostOwner
            // 
            this.btn_lookPostOwner.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_lookPostOwner.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_lookPostOwner.Location = new System.Drawing.Point(297, 31);
            this.btn_lookPostOwner.Name = "btn_lookPostOwner";
            this.btn_lookPostOwner.Size = new System.Drawing.Size(125, 186);
            this.btn_lookPostOwner.TabIndex = 18;
            this.btn_lookPostOwner.Text = "查看贴主信息";
            this.btn_lookPostOwner.UseVisualStyleBackColor = false;
            this.btn_lookPostOwner.Click += new System.EventHandler(this.btn_lookPostOwner_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox.Location = new System.Drawing.Point(111, 408);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(311, 318);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // richTextBox_comment
            // 
            this.richTextBox_comment.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox_comment.Location = new System.Drawing.Point(445, 12);
            this.richTextBox_comment.Name = "richTextBox_comment";
            this.richTextBox_comment.Size = new System.Drawing.Size(605, 93);
            this.richTextBox_comment.TabIndex = 19;
            this.richTextBox_comment.Text = "";
            // 
            // button_comment
            // 
            this.button_comment.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_comment.Font = new System.Drawing.Font("宋体", 11F);
            this.button_comment.Location = new System.Drawing.Point(1057, 56);
            this.button_comment.Name = "button_comment";
            this.button_comment.Size = new System.Drawing.Size(113, 49);
            this.button_comment.TabIndex = 20;
            this.button_comment.Text = "发表评论";
            this.button_comment.UseVisualStyleBackColor = false;
            this.button_comment.Click += new System.EventHandler(this.button_comment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.commentContextDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.deleteComment,
            this.tipOffComment,
            this.CommentId,
            this.PostId,
            this.UserId});
            this.dataGridView1.DataSource = this.commentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(445, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(725, 630);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentContextDataGridViewTextBoxColumn
            // 
            this.commentContextDataGridViewTextBoxColumn.DataPropertyName = "CommentContext";
            this.commentContextDataGridViewTextBoxColumn.HeaderText = "评论内容";
            this.commentContextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentContextDataGridViewTextBoxColumn.Name = "commentContextDataGridViewTextBoxColumn";
            this.commentContextDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "评论时间";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // deleteComment
            // 
            this.deleteComment.HeaderText = "删除";
            this.deleteComment.MinimumWidth = 6;
            this.deleteComment.Name = "deleteComment";
            this.deleteComment.Width = 125;
            // 
            // tipOffComment
            // 
            this.tipOffComment.HeaderText = "举报";
            this.tipOffComment.MinimumWidth = 6;
            this.tipOffComment.Name = "tipOffComment";
            this.tipOffComment.Width = 125;
            // 
            // CommentId
            // 
            this.CommentId.DataPropertyName = "CommentId";
            this.CommentId.HeaderText = "CommentId";
            this.CommentId.MinimumWidth = 6;
            this.CommentId.Name = "CommentId";
            this.CommentId.Visible = false;
            this.CommentId.Width = 125;
            // 
            // PostId
            // 
            this.PostId.DataPropertyName = "PostId";
            this.PostId.HeaderText = "PostId";
            this.PostId.MinimumWidth = 6;
            this.PostId.Name = "PostId";
            this.PostId.Visible = false;
            this.PostId.Width = 125;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.AllowNew = false;
            this.commentBindingSource.DataSource = typeof(HunterClient.EntityClass.Comment);
            // 
            // Form_postDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_comment);
            this.Controls.Add(this.richTextBox_comment);
            this.Controls.Add(this.btn_comment);
            this.Name = "Form_postDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_postDetail";
            this.btn_comment.ResumeLayout(false);
            this.btn_comment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_postType;
        private System.Windows.Forms.Panel btn_comment;
        private System.Windows.Forms.RichTextBox richTextBox_comment;
        private System.Windows.Forms.Button button_comment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.Button btn_lookPostOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentContextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteComment;
        private System.Windows.Forms.DataGridViewButtonColumn tipOffComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
    }
}