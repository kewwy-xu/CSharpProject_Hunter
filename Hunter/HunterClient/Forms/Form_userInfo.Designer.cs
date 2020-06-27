namespace HunterClient.Forms
{
    partial class Form_userInfo
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
            this.tB_regwechat = new System.Windows.Forms.TextBox();
            this.tB_regqq = new System.Windows.Forms.TextBox();
            this.tB_regemail = new System.Windows.Forms.TextBox();
            this.tB_regpassword2 = new System.Windows.Forms.TextBox();
            this.tB_regpassword1 = new System.Windows.Forms.TextBox();
            this.tB_regnickname = new System.Windows.Forms.TextBox();
            this.lab_regwechat = new System.Windows.Forms.Label();
            this.lab_regqq = new System.Windows.Forms.Label();
            this.lab_regemail = new System.Windows.Forms.Label();
            this.lab_regpassword2 = new System.Windows.Forms.Label();
            this.lab_regpassword1 = new System.Windows.Forms.Label();
            this.lab_regnickname = new System.Windows.Forms.Label();
            this.btn_userinfochange = new System.Windows.Forms.Button();
            this.btn_myPosts = new System.Windows.Forms.Button();
            this.btn_collects = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.postDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_alter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_postType = new System.Windows.Forms.ComboBox();
            this.comboBox_timeOrder = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_searchInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_maxPrice = new System.Windows.Forms.TextBox();
            this.textBox_minPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_priceOrder = new System.Windows.Forms.ComboBox();
            this.label_myPostsOrCollects = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_regwechat
            // 
            this.tB_regwechat.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regwechat.Location = new System.Drawing.Point(144, 264);
            this.tB_regwechat.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regwechat.Name = "tB_regwechat";
            this.tB_regwechat.Size = new System.Drawing.Size(199, 25);
            this.tB_regwechat.TabIndex = 23;
            // 
            // tB_regqq
            // 
            this.tB_regqq.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regqq.Location = new System.Drawing.Point(144, 204);
            this.tB_regqq.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regqq.Name = "tB_regqq";
            this.tB_regqq.Size = new System.Drawing.Size(199, 25);
            this.tB_regqq.TabIndex = 22;
            // 
            // tB_regemail
            // 
            this.tB_regemail.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regemail.Location = new System.Drawing.Point(144, 161);
            this.tB_regemail.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regemail.Name = "tB_regemail";
            this.tB_regemail.ReadOnly = true;
            this.tB_regemail.Size = new System.Drawing.Size(200, 25);
            this.tB_regemail.TabIndex = 21;
            // 
            // tB_regpassword2
            // 
            this.tB_regpassword2.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regpassword2.Location = new System.Drawing.Point(144, 119);
            this.tB_regpassword2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regpassword2.Name = "tB_regpassword2";
            this.tB_regpassword2.PasswordChar = '*';
            this.tB_regpassword2.Size = new System.Drawing.Size(199, 25);
            this.tB_regpassword2.TabIndex = 20;
            // 
            // tB_regpassword1
            // 
            this.tB_regpassword1.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regpassword1.Location = new System.Drawing.Point(144, 64);
            this.tB_regpassword1.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regpassword1.Name = "tB_regpassword1";
            this.tB_regpassword1.PasswordChar = '*';
            this.tB_regpassword1.Size = new System.Drawing.Size(200, 25);
            this.tB_regpassword1.TabIndex = 19;
            // 
            // tB_regnickname
            // 
            this.tB_regnickname.BackColor = System.Drawing.Color.SeaShell;
            this.tB_regnickname.Location = new System.Drawing.Point(144, 19);
            this.tB_regnickname.Margin = new System.Windows.Forms.Padding(4);
            this.tB_regnickname.Name = "tB_regnickname";
            this.tB_regnickname.ReadOnly = true;
            this.tB_regnickname.Size = new System.Drawing.Size(200, 25);
            this.tB_regnickname.TabIndex = 18;
            // 
            // lab_regwechat
            // 
            this.lab_regwechat.AutoSize = true;
            this.lab_regwechat.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regwechat.Location = new System.Drawing.Point(65, 259);
            this.lab_regwechat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regwechat.Name = "lab_regwechat";
            this.lab_regwechat.Size = new System.Drawing.Size(58, 24);
            this.lab_regwechat.TabIndex = 17;
            this.lab_regwechat.Text = "微信";
            // 
            // lab_regqq
            // 
            this.lab_regqq.AutoSize = true;
            this.lab_regqq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regqq.Location = new System.Drawing.Point(89, 205);
            this.lab_regqq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regqq.Name = "lab_regqq";
            this.lab_regqq.Size = new System.Drawing.Size(34, 24);
            this.lab_regqq.TabIndex = 16;
            this.lab_regqq.Text = "QQ";
            // 
            // lab_regemail
            // 
            this.lab_regemail.AutoSize = true;
            this.lab_regemail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regemail.Location = new System.Drawing.Point(18, 156);
            this.lab_regemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regemail.Name = "lab_regemail";
            this.lab_regemail.Size = new System.Drawing.Size(106, 24);
            this.lab_regemail.TabIndex = 15;
            this.lab_regemail.Text = "邮箱地址";
            // 
            // lab_regpassword2
            // 
            this.lab_regpassword2.AutoSize = true;
            this.lab_regpassword2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regpassword2.Location = new System.Drawing.Point(18, 114);
            this.lab_regpassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regpassword2.Name = "lab_regpassword2";
            this.lab_regpassword2.Size = new System.Drawing.Size(106, 24);
            this.lab_regpassword2.TabIndex = 14;
            this.lab_regpassword2.Text = "确认密码";
            // 
            // lab_regpassword1
            // 
            this.lab_regpassword1.AutoSize = true;
            this.lab_regpassword1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regpassword1.Location = new System.Drawing.Point(18, 65);
            this.lab_regpassword1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regpassword1.Name = "lab_regpassword1";
            this.lab_regpassword1.Size = new System.Drawing.Size(106, 24);
            this.lab_regpassword1.TabIndex = 13;
            this.lab_regpassword1.Text = "修改密码";
            // 
            // lab_regnickname
            // 
            this.lab_regnickname.AutoSize = true;
            this.lab_regnickname.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_regnickname.Location = new System.Drawing.Point(42, 19);
            this.lab_regnickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_regnickname.Name = "lab_regnickname";
            this.lab_regnickname.Size = new System.Drawing.Size(82, 24);
            this.lab_regnickname.TabIndex = 12;
            this.lab_regnickname.Text = "用户名";
            // 
            // btn_userinfochange
            // 
            this.btn_userinfochange.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_userinfochange.Location = new System.Drawing.Point(250, 677);
            this.btn_userinfochange.Margin = new System.Windows.Forms.Padding(4);
            this.btn_userinfochange.Name = "btn_userinfochange";
            this.btn_userinfochange.Size = new System.Drawing.Size(112, 40);
            this.btn_userinfochange.TabIndex = 24;
            this.btn_userinfochange.Text = "保存修改";
            this.btn_userinfochange.UseVisualStyleBackColor = false;
            this.btn_userinfochange.Click += new System.EventHandler(this.btn_userinfochange_Click);
            // 
            // btn_myPosts
            // 
            this.btn_myPosts.BackColor = System.Drawing.SystemColors.Info;
            this.btn_myPosts.Location = new System.Drawing.Point(9, 8);
            this.btn_myPosts.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btn_myPosts.Name = "btn_myPosts";
            this.btn_myPosts.Size = new System.Drawing.Size(145, 50);
            this.btn_myPosts.TabIndex = 25;
            this.btn_myPosts.Text = "我的帖子";
            this.btn_myPosts.UseVisualStyleBackColor = false;
            this.btn_myPosts.Click += new System.EventHandler(this.btn_myPosts_Click);
            // 
            // btn_collects
            // 
            this.btn_collects.BackColor = System.Drawing.SystemColors.Info;
            this.btn_collects.Location = new System.Drawing.Point(9, 66);
            this.btn_collects.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btn_collects.Name = "btn_collects";
            this.btn_collects.Size = new System.Drawing.Size(145, 50);
            this.btn_collects.TabIndex = 26;
            this.btn_collects.Text = "收藏";
            this.btn_collects.UseVisualStyleBackColor = false;
            this.btn_collects.Click += new System.EventHandler(this.btn_collects_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lab_regnickname);
            this.panel1.Controls.Add(this.tB_regnickname);
            this.panel1.Controls.Add(this.lab_regpassword1);
            this.panel1.Controls.Add(this.tB_regpassword1);
            this.panel1.Controls.Add(this.lab_regpassword2);
            this.panel1.Controls.Add(this.tB_regpassword2);
            this.panel1.Controls.Add(this.btn_userinfochange);
            this.panel1.Controls.Add(this.lab_regemail);
            this.panel1.Controls.Add(this.tB_regwechat);
            this.panel1.Controls.Add(this.tB_regemail);
            this.panel1.Controls.Add(this.lab_regwechat);
            this.panel1.Controls.Add(this.tB_regqq);
            this.panel1.Controls.Add(this.lab_regqq);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 726);
            this.panel1.TabIndex = 30;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Beige;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "数码产品",
            "家用电器",
            "运动户外",
            "衣帽鞋伞",
            "书籍教材",
            "游戏装备",
            "健身器材",
            "日常用品",
            "乐器",
            "代写代做代跑",
            "其他"});
            this.checkedListBox1.Location = new System.Drawing.Point(22, 448);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(221, 264);
            this.checkedListBox1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label6.Location = new System.Drawing.Point(18, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "偏好 ：";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_address.Location = new System.Drawing.Point(21, 332);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(323, 67);
            this.textBox_address.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label5.Location = new System.Drawing.Point(18, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "地址 ：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_myPosts);
            this.flowLayoutPanel1.Controls.Add(this.btn_collects);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(496, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 126);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.postTypeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.postDetail,
            this.btn_delete,
            this.btn_alter,
            this.PostId});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(384, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(790, 470);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 53;
            // 
            // postDetail
            // 
            this.postDetail.HeaderText = "查看详情";
            this.postDetail.MinimumWidth = 6;
            this.postDetail.Name = "postDetail";
            this.postDetail.ReadOnly = true;
            this.postDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.postDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.postDetail.Width = 96;
            // 
            // btn_delete
            // 
            this.btn_delete.HeaderText = "删除";
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Width = 43;
            // 
            // btn_alter
            // 
            this.btn_alter.HeaderText = "修改";
            this.btn_alter.MinimumWidth = 6;
            this.btn_alter.Name = "btn_alter";
            this.btn_alter.ReadOnly = true;
            this.btn_alter.Width = 43;
            // 
            // PostId
            // 
            this.PostId.DataPropertyName = "PostId";
            this.PostId.HeaderText = "PostId";
            this.PostId.MinimumWidth = 6;
            this.PostId.Name = "PostId";
            this.PostId.ReadOnly = true;
            this.PostId.Visible = false;
            this.PostId.Width = 84;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.comboBox_postType);
            this.panel2.Controls.Add(this.comboBox_timeOrder);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox_searchInput);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.comboBox_priceOrder);
            this.panel2.Location = new System.Drawing.Point(384, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 243);
            this.panel2.TabIndex = 33;
            // 
            // comboBox_postType
            // 
            this.comboBox_postType.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox_postType.FormattingEnabled = true;
            this.comboBox_postType.Items.AddRange(new object[] {
            "出售",
            "求购"});
            this.comboBox_postType.Location = new System.Drawing.Point(350, 117);
            this.comboBox_postType.Name = "comboBox_postType";
            this.comboBox_postType.Size = new System.Drawing.Size(89, 23);
            this.comboBox_postType.TabIndex = 8;
            this.comboBox_postType.Text = "出售";
            // 
            // comboBox_timeOrder
            // 
            this.comboBox_timeOrder.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox_timeOrder.FormattingEnabled = true;
            this.comboBox_timeOrder.Items.AddRange(new object[] {
            "按时间升序",
            "按时间降序"});
            this.comboBox_timeOrder.Location = new System.Drawing.Point(350, 36);
            this.comboBox_timeOrder.Name = "comboBox_timeOrder";
            this.comboBox_timeOrder.Size = new System.Drawing.Size(113, 23);
            this.comboBox_timeOrder.TabIndex = 7;
            this.comboBox_timeOrder.Text = "按时间降序";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_search.Font = new System.Drawing.Font("黑体", 12F);
            this.btn_search.Location = new System.Drawing.Point(658, 198);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_searchInput
            // 
            this.textBox_searchInput.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_searchInput.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox_searchInput.Location = new System.Drawing.Point(20, 199);
            this.textBox_searchInput.Name = "textBox_searchInput";
            this.textBox_searchInput.Size = new System.Drawing.Size(615, 36);
            this.textBox_searchInput.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 178);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker_end);
            this.tabPage1.Controls.Add(this.dateTimePicker_begin);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上架时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "终止时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始时间";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(103, 101);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_end.TabIndex = 1;
            this.dateTimePicker_end.Value = new System.DateTime(2020, 6, 20, 0, 0, 0, 0);
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(103, 40);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_begin.TabIndex = 0;
            this.dateTimePicker_begin.Value = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Beige;
            this.tabPage2.Controls.Add(this.textBox_maxPrice);
            this.tabPage2.Controls.Add(this.textBox_minPrice);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "价格区间";
            // 
            // textBox_maxPrice
            // 
            this.textBox_maxPrice.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_maxPrice.Location = new System.Drawing.Point(129, 91);
            this.textBox_maxPrice.Name = "textBox_maxPrice";
            this.textBox_maxPrice.Size = new System.Drawing.Size(141, 25);
            this.textBox_maxPrice.TabIndex = 3;
            this.textBox_maxPrice.Text = "10000000";
            // 
            // textBox_minPrice
            // 
            this.textBox_minPrice.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_minPrice.Location = new System.Drawing.Point(129, 40);
            this.textBox_minPrice.Name = "textBox_minPrice";
            this.textBox_minPrice.Size = new System.Drawing.Size(141, 25);
            this.textBox_minPrice.TabIndex = 2;
            this.textBox_minPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "最高价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "最低价格";
            // 
            // comboBox_priceOrder
            // 
            this.comboBox_priceOrder.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox_priceOrder.FormattingEnabled = true;
            this.comboBox_priceOrder.Items.AddRange(new object[] {
            "按价格升序",
            "按价格降序"});
            this.comboBox_priceOrder.Location = new System.Drawing.Point(350, 76);
            this.comboBox_priceOrder.Name = "comboBox_priceOrder";
            this.comboBox_priceOrder.Size = new System.Drawing.Size(113, 23);
            this.comboBox_priceOrder.TabIndex = 5;
            this.comboBox_priceOrder.Text = "按价格升序";
            // 
            // label_myPostsOrCollects
            // 
            this.label_myPostsOrCollects.AutoSize = true;
            this.label_myPostsOrCollects.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_myPostsOrCollects.Location = new System.Drawing.Point(387, 258);
            this.label_myPostsOrCollects.Name = "label_myPostsOrCollects";
            this.label_myPostsOrCollects.Size = new System.Drawing.Size(67, 15);
            this.label_myPostsOrCollects.TabIndex = 34;
            this.label_myPostsOrCollects.Text = "我的帖子";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 66;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "时间";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 66;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "商品类型";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 96;
            // 
            // postTypeDataGridViewTextBoxColumn
            // 
            this.postTypeDataGridViewTextBoxColumn.DataPropertyName = "PostType";
            this.postTypeDataGridViewTextBoxColumn.HeaderText = "帖子类型";
            this.postTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postTypeDataGridViewTextBoxColumn.Name = "postTypeDataGridViewTextBoxColumn";
            this.postTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.postTypeDataGridViewTextBoxColumn.Width = 96;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 66;
            // 
            // postBindingSource
            // 
            this.postBindingSource.AllowNew = false;
            this.postBindingSource.DataSource = typeof(HunterClient.EntityClass.Post);
            // 
            // Form_userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label_myPostsOrCollects);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_userInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人中心";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_regwechat;
        private System.Windows.Forms.TextBox tB_regqq;
        private System.Windows.Forms.TextBox tB_regemail;
        private System.Windows.Forms.TextBox tB_regpassword2;
        private System.Windows.Forms.TextBox tB_regpassword1;
        private System.Windows.Forms.TextBox tB_regnickname;
        private System.Windows.Forms.Label lab_regwechat;
        private System.Windows.Forms.Label lab_regqq;
        private System.Windows.Forms.Label lab_regemail;
        private System.Windows.Forms.Label lab_regpassword2;
        private System.Windows.Forms.Label lab_regpassword1;
        private System.Windows.Forms.Label lab_regnickname;
        private System.Windows.Forms.Button btn_userinfochange;
        private System.Windows.Forms.Button btn_myPosts;
        private System.Windows.Forms.Button btn_collects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_postType;
        private System.Windows.Forms.ComboBox comboBox_timeOrder;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_searchInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_maxPrice;
        private System.Windows.Forms.TextBox textBox_minPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_priceOrder;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_myPostsOrCollects;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn postDetail;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
        private System.Windows.Forms.DataGridViewButtonColumn btn_alter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostId;
    }
}