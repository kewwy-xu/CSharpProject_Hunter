namespace WinForm
{
    partial class Form_reg
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
            this.lab_regnickname = new System.Windows.Forms.Label();
            this.lab_regpassword1 = new System.Windows.Forms.Label();
            this.lab_regpassword2 = new System.Windows.Forms.Label();
            this.lab_regemail = new System.Windows.Forms.Label();
            this.lab_regqq = new System.Windows.Forms.Label();
            this.lab_regwechat = new System.Windows.Forms.Label();
            this.tB_regnickname = new System.Windows.Forms.TextBox();
            this.tB_regpassword1 = new System.Windows.Forms.TextBox();
            this.tB_regpassword2 = new System.Windows.Forms.TextBox();
            this.tB_regemail = new System.Windows.Forms.TextBox();
            this.tB_regqq = new System.Windows.Forms.TextBox();
            this.tB_regwechat = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_regtologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_regnickname
            // 
            this.lab_regnickname.AutoSize = true;
            this.lab_regnickname.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regnickname.Location = new System.Drawing.Point(324, 62);
            this.lab_regnickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regnickname.Name = "lab_regnickname";
            this.lab_regnickname.Size = new System.Drawing.Size(118, 24);
            this.lab_regnickname.TabIndex = 0;
            this.lab_regnickname.Text = "用户名 ：";
            this.lab_regnickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_regpassword1
            // 
            this.lab_regpassword1.AutoSize = true;
            this.lab_regpassword1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regpassword1.Location = new System.Drawing.Point(336, 115);
            this.lab_regpassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regpassword1.Name = "lab_regpassword1";
            this.lab_regpassword1.Size = new System.Drawing.Size(106, 24);
            this.lab_regpassword1.TabIndex = 1;
            this.lab_regpassword1.Text = "密码  ：";
            // 
            // lab_regpassword2
            // 
            this.lab_regpassword2.AutoSize = true;
            this.lab_regpassword2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regpassword2.Location = new System.Drawing.Point(285, 166);
            this.lab_regpassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regpassword2.Name = "lab_regpassword2";
            this.lab_regpassword2.Size = new System.Drawing.Size(154, 24);
            this.lab_regpassword2.TabIndex = 2;
            this.lab_regpassword2.Text = "确认密码  ：";
            // 
            // lab_regemail
            // 
            this.lab_regemail.AutoSize = true;
            this.lab_regemail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regemail.Location = new System.Drawing.Point(299, 220);
            this.lab_regemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regemail.Name = "lab_regemail";
            this.lab_regemail.Size = new System.Drawing.Size(142, 24);
            this.lab_regemail.TabIndex = 3;
            this.lab_regemail.Text = "邮箱地址 ：";
            // 
            // lab_regqq
            // 
            this.lab_regqq.AutoSize = true;
            this.lab_regqq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regqq.Location = new System.Drawing.Point(373, 272);
            this.lab_regqq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regqq.Name = "lab_regqq";
            this.lab_regqq.Size = new System.Drawing.Size(70, 24);
            this.lab_regqq.TabIndex = 4;
            this.lab_regqq.Text = "QQ ：";
            // 
            // lab_regwechat
            // 
            this.lab_regwechat.AutoSize = true;
            this.lab_regwechat.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regwechat.Location = new System.Drawing.Point(349, 330);
            this.lab_regwechat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regwechat.Name = "lab_regwechat";
            this.lab_regwechat.Size = new System.Drawing.Size(94, 24);
            this.lab_regwechat.TabIndex = 5;
            this.lab_regwechat.Text = "微信 ：";
            // 
            // tB_regnickname
            // 
            this.tB_regnickname.Location = new System.Drawing.Point(459, 60);
            this.tB_regnickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regnickname.Name = "tB_regnickname";
            this.tB_regnickname.Size = new System.Drawing.Size(176, 25);
            this.tB_regnickname.TabIndex = 6;
            // 
            // tB_regpassword1
            // 
            this.tB_regpassword1.Location = new System.Drawing.Point(459, 112);
            this.tB_regpassword1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regpassword1.Name = "tB_regpassword1";
            this.tB_regpassword1.Size = new System.Drawing.Size(176, 25);
            this.tB_regpassword1.TabIndex = 7;
            // 
            // tB_regpassword2
            // 
            this.tB_regpassword2.Location = new System.Drawing.Point(459, 164);
            this.tB_regpassword2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regpassword2.Name = "tB_regpassword2";
            this.tB_regpassword2.Size = new System.Drawing.Size(176, 25);
            this.tB_regpassword2.TabIndex = 8;
            // 
            // tB_regemail
            // 
            this.tB_regemail.Location = new System.Drawing.Point(459, 218);
            this.tB_regemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regemail.Name = "tB_regemail";
            this.tB_regemail.Size = new System.Drawing.Size(176, 25);
            this.tB_regemail.TabIndex = 9;
            // 
            // tB_regqq
            // 
            this.tB_regqq.Location = new System.Drawing.Point(459, 272);
            this.tB_regqq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regqq.Name = "tB_regqq";
            this.tB_regqq.Size = new System.Drawing.Size(176, 25);
            this.tB_regqq.TabIndex = 10;
            // 
            // tB_regwechat
            // 
            this.tB_regwechat.Location = new System.Drawing.Point(459, 328);
            this.tB_regwechat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regwechat.Name = "tB_regwechat";
            this.tB_regwechat.Size = new System.Drawing.Size(176, 25);
            this.tB_regwechat.TabIndex = 11;
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reg.Location = new System.Drawing.Point(355, 412);
            this.btn_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(111, 44);
            this.btn_reg.TabIndex = 12;
            this.btn_reg.Text = "注册";
            this.btn_reg.UseVisualStyleBackColor = true;
            // 
            // btn_regtologin
            // 
            this.btn_regtologin.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_regtologin.Location = new System.Drawing.Point(543, 412);
            this.btn_regtologin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regtologin.Name = "btn_regtologin";
            this.btn_regtologin.Size = new System.Drawing.Size(135, 44);
            this.btn_regtologin.TabIndex = 13;
            this.btn_regtologin.Text = "返回登录";
            this.btn_regtologin.UseVisualStyleBackColor = true;
            // 
            // Form_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 560);
            this.Controls.Add(this.btn_regtologin);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.tB_regwechat);
            this.Controls.Add(this.tB_regqq);
            this.Controls.Add(this.tB_regemail);
            this.Controls.Add(this.tB_regpassword2);
            this.Controls.Add(this.tB_regpassword1);
            this.Controls.Add(this.tB_regnickname);
            this.Controls.Add(this.lab_regwechat);
            this.Controls.Add(this.lab_regqq);
            this.Controls.Add(this.lab_regemail);
            this.Controls.Add(this.lab_regpassword2);
            this.Controls.Add(this.lab_regpassword1);
            this.Controls.Add(this.lab_regnickname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_reg";
            this.Text = "Form_reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_regnickname;
        private System.Windows.Forms.Label lab_regpassword1;
        private System.Windows.Forms.Label lab_regpassword2;
        private System.Windows.Forms.Label lab_regemail;
        private System.Windows.Forms.Label lab_regqq;
        private System.Windows.Forms.Label lab_regwechat;
        private System.Windows.Forms.TextBox tB_regnickname;
        private System.Windows.Forms.TextBox tB_regpassword1;
        private System.Windows.Forms.TextBox tB_regpassword2;
        private System.Windows.Forms.TextBox tB_regemail;
        private System.Windows.Forms.TextBox tB_regqq;
        private System.Windows.Forms.TextBox tB_regwechat;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_regtologin;
    }
}