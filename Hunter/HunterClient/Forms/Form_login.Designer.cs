namespace HunterClient.Forms
{
    partial class Form_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_hunter = new System.Windows.Forms.Label();
            this.linkLab_reg = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_nickname = new HunterClient.Forms.TextBoxEx();
            this.tB_password = new HunterClient.Forms.TextBoxEx();
            this.link_password = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_hunter
            // 
            this.lab_hunter.AutoSize = true;
            this.lab_hunter.Font = new System.Drawing.Font("楷体", 20F);
            this.lab_hunter.Location = new System.Drawing.Point(300, 37);
            this.lab_hunter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_hunter.Name = "lab_hunter";
            this.lab_hunter.Size = new System.Drawing.Size(389, 34);
            this.lab_hunter.TabIndex = 4;
            this.lab_hunter.Text = "HUNTER校内物品交易平台";
            // 
            // linkLab_reg
            // 
            this.linkLab_reg.AutoSize = true;
            this.linkLab_reg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLab_reg.Location = new System.Drawing.Point(404, 413);
            this.linkLab_reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLab_reg.Name = "linkLab_reg";
            this.linkLab_reg.Size = new System.Drawing.Size(189, 20);
            this.linkLab_reg.TabIndex = 5;
            this.linkLab_reg.TabStop = true;
            this.linkLab_reg.Text = "没有账号？注册一个";
            this.linkLab_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLab_reg_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(349, 500);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(304, 40);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.lab_hunter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 7;
            // 
            // tB_nickname
            // 
            this.tB_nickname.BackColor = System.Drawing.Color.SeaShell;
            this.tB_nickname.BackGroundText = "请输入用户名";
            this.tB_nickname.Font = new System.Drawing.Font("宋体", 15F);
            this.tB_nickname.Location = new System.Drawing.Point(388, 241);
            this.tB_nickname.Name = "tB_nickname";
            this.tB_nickname.Size = new System.Drawing.Size(265, 36);
            this.tB_nickname.TabIndex = 8;
            // 
            // tB_password
            // 
            this.tB_password.BackColor = System.Drawing.Color.SeaShell;
            this.tB_password.BackGroundText = "请输入密码";
            this.tB_password.Font = new System.Drawing.Font("宋体", 15F);
            this.tB_password.Location = new System.Drawing.Point(388, 331);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(265, 36);
            this.tB_password.TabIndex = 9;
            // 
            // link_password
            // 
            this.link_password.AutoSize = true;
            this.link_password.Font = new System.Drawing.Font("宋体", 12F);
            this.link_password.Location = new System.Drawing.Point(450, 464);
            this.link_password.Name = "link_password";
            this.link_password.Size = new System.Drawing.Size(109, 20);
            this.link_password.TabIndex = 11;
            this.link_password.TabStop = true;
            this.link_password.Text = "忘记密码？";
            this.link_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_password_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Hunter.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(346, 241);
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
            this.pictureBox1.Image = global::Hunter.Properties.Resources.testword;
            this.pictureBox1.Location = new System.Drawing.Point(346, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.link_password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_nickname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.linkLab_reg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_hunter;
        private System.Windows.Forms.LinkLabel linkLab_reg;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private TextBoxEx tB_nickname;
        private TextBoxEx tB_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel link_password;
    }
}

