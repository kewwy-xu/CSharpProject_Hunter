﻿namespace Hunter
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
            this.lab_nickname = new System.Windows.Forms.Label();
            this.tB_nickname = new System.Windows.Forms.TextBox();
            this.lab_password = new System.Windows.Forms.Label();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.lab_hunter = new System.Windows.Forms.Label();
            this.linkLab_reg = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_nickname
            // 
            this.lab_nickname.AutoSize = true;
            this.lab_nickname.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_nickname.Location = new System.Drawing.Point(185, 159);
            this.lab_nickname.Name = "lab_nickname";
            this.lab_nickname.Size = new System.Drawing.Size(95, 19);
            this.lab_nickname.TabIndex = 0;
            this.lab_nickname.Text = "用户名 ：";
            // 
            // tB_nickname
            // 
            this.tB_nickname.Location = new System.Drawing.Point(276, 157);
            this.tB_nickname.Name = "tB_nickname";
            this.tB_nickname.Size = new System.Drawing.Size(218, 21);
            this.tB_nickname.TabIndex = 1;
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_password.Location = new System.Drawing.Point(194, 220);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(86, 19);
            this.lab_password.TabIndex = 2;
            this.lab_password.Text = "密码  ：";
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(276, 220);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(218, 21);
            this.tB_password.TabIndex = 3;
            // 
            // lab_hunter
            // 
            this.lab_hunter.AutoSize = true;
            this.lab_hunter.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_hunter.Location = new System.Drawing.Point(265, 44);
            this.lab_hunter.Name = "lab_hunter";
            this.lab_hunter.Size = new System.Drawing.Size(229, 20);
            this.lab_hunter.TabIndex = 4;
            this.lab_hunter.Text = "HUNTER校内物品交易平台";
            // 
            // linkLab_reg
            // 
            this.linkLab_reg.AutoSize = true;
            this.linkLab_reg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLab_reg.Location = new System.Drawing.Point(301, 319);
            this.linkLab_reg.Name = "linkLab_reg";
            this.linkLab_reg.Size = new System.Drawing.Size(152, 16);
            this.linkLab_reg.TabIndex = 5;
            this.linkLab_reg.TabStop = true;
            this.linkLab_reg.Text = "没有账号？注册一个";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(325, 270);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 32);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 522);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.linkLab_reg);
            this.Controls.Add(this.lab_hunter);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.tB_nickname);
            this.Controls.Add(this.lab_nickname);
            this.Name = "Form_login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_nickname;
        private System.Windows.Forms.TextBox tB_nickname;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.Label lab_hunter;
        private System.Windows.Forms.LinkLabel linkLab_reg;
        private System.Windows.Forms.Button btn_login;
    }
}

