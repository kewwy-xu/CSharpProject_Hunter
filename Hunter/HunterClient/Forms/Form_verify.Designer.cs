namespace HunterClient.Forms
{
    partial class Form_verify
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
            this.button_test = new System.Windows.Forms.Button();
            this.button_post = new System.Windows.Forms.Button();
            this.textBox_email = new HunterClient.Forms.TextBoxEx();
            this.textBox_test = new HunterClient.Forms.TextBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_hunter = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_test.Font = new System.Drawing.Font("宋体", 15F);
            this.button_test.Location = new System.Drawing.Point(252, 333);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(270, 40);
            this.button_test.TabIndex = 1;
            this.button_test.Text = "验证登录";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_post
            // 
            this.button_post.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_post.Font = new System.Drawing.Font("宋体", 15F);
            this.button_post.Location = new System.Drawing.Point(312, 272);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(151, 41);
            this.button_post.TabIndex = 2;
            this.button_post.Text = "发送验证码";
            this.button_post.UseVisualStyleBackColor = false;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_email.BackGroundText = "请输入邮箱";
            this.textBox_email.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox_email.Location = new System.Drawing.Point(252, 145);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(270, 36);
            this.textBox_email.TabIndex = 0;
            // 
            // textBox_test
            // 
            this.textBox_test.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_test.BackGroundText = "请输入验证码";
            this.textBox_test.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox_test.Location = new System.Drawing.Point(252, 210);
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(270, 36);
            this.textBox_test.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.lab_hunter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // lab_hunter
            // 
            this.lab_hunter.AutoSize = true;
            this.lab_hunter.Font = new System.Drawing.Font("楷体", 20F);
            this.lab_hunter.Location = new System.Drawing.Point(275, 35);
            this.lab_hunter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_hunter.Name = "lab_hunter";
            this.lab_hunter.Size = new System.Drawing.Size(219, 34);
            this.lab_hunter.TabIndex = 4;
            this.lab_hunter.Text = "邮箱验证登陆";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Hunter.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(213, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Hunter.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(213, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_test);
            this.Controls.Add(this.button_post);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.textBox_email);
            this.Name = "Form_verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_verify";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_post;
        private HunterClient.Forms.TextBoxEx textBox_email;
        private HunterClient.Forms.TextBoxEx textBox_test;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_hunter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}