namespace HunterClient.Forms
{
    partial class Form_main
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_userinfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_collect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addPost = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_type = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_postType = new System.Windows.Forms.ComboBox();
            this.comboBox_timeOrder = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_searchInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_maxPrice = new System.Windows.Forms.TextBox();
            this.textBox_minPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_priceOrder = new System.Windows.Forms.ComboBox();
            this.btn_allPosts = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Beige;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 231);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(17, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 510);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("黑体", 12F);
            this.button1.Location = new System.Drawing.Point(20, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "数码产品";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button3.Font = new System.Drawing.Font("黑体", 12F);
            this.button3.Location = new System.Drawing.Point(20, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "运动户外";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Font = new System.Drawing.Font("黑体", 12F);
            this.button2.Location = new System.Drawing.Point(20, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "家用电器";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LemonChiffon;
            this.button4.Font = new System.Drawing.Font("黑体", 12F);
            this.button4.Location = new System.Drawing.Point(20, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "衣帽鞋伞";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.Font = new System.Drawing.Font("黑体", 12F);
            this.button5.Location = new System.Drawing.Point(20, 197);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "书籍教材";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LemonChiffon;
            this.button6.Font = new System.Drawing.Font("黑体", 12F);
            this.button6.Location = new System.Drawing.Point(20, 242);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 32);
            this.button6.TabIndex = 5;
            this.button6.Text = "游戏装备";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LemonChiffon;
            this.button8.Font = new System.Drawing.Font("黑体", 12F);
            this.button8.Location = new System.Drawing.Point(20, 287);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 32);
            this.button8.TabIndex = 7;
            this.button8.Text = "健身器材";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LemonChiffon;
            this.button7.Font = new System.Drawing.Font("黑体", 12F);
            this.button7.Location = new System.Drawing.Point(20, 332);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "日常用品";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LemonChiffon;
            this.button10.Font = new System.Drawing.Font("黑体", 12F);
            this.button10.Location = new System.Drawing.Point(20, 374);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 28);
            this.button10.TabIndex = 9;
            this.button10.Text = "乐器";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LemonChiffon;
            this.button11.Font = new System.Drawing.Font("黑体", 12F);
            this.button11.Location = new System.Drawing.Point(20, 415);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 32);
            this.button11.TabIndex = 10;
            this.button11.Text = "代写代做代跑";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LemonChiffon;
            this.button12.Font = new System.Drawing.Font("黑体", 12F);
            this.button12.Location = new System.Drawing.Point(20, 460);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 33);
            this.button12.TabIndex = 11;
            this.button12.Text = "其他";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_userinfo
            // 
            this.btn_userinfo.BackColor = System.Drawing.SystemColors.Info;
            this.btn_userinfo.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_userinfo.Location = new System.Drawing.Point(10, 10);
            this.btn_userinfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btn_userinfo.Name = "btn_userinfo";
            this.btn_userinfo.Size = new System.Drawing.Size(145, 67);
            this.btn_userinfo.TabIndex = 8;
            this.btn_userinfo.Text = "个人中心";
            this.btn_userinfo.UseVisualStyleBackColor = false;
            this.btn_userinfo.Click += new System.EventHandler(this.btn_userinfo_Click);
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
            this.typeDataGridViewTextBoxColumn,
            this.postTypeDataGridViewTextBoxColumn,
            this.detail,
            this.btn_collect,
            this.PostId,
            this.UserId});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(182, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(988, 510);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.Frozen = true;
            this.Image.HeaderText = "图片";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 43;
            // 
            // detail
            // 
            this.detail.Frozen = true;
            this.detail.HeaderText = "查看详情";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.Width = 73;
            // 
            // btn_collect
            // 
            this.btn_collect.Frozen = true;
            this.btn_collect.HeaderText = "收藏";
            this.btn_collect.MinimumWidth = 6;
            this.btn_collect.Name = "btn_collect";
            this.btn_collect.Width = 43;
            // 
            // PostId
            // 
            this.PostId.DataPropertyName = "PostId";
            this.PostId.Frozen = true;
            this.PostId.HeaderText = "PostId";
            this.PostId.MinimumWidth = 6;
            this.PostId.Name = "PostId";
            this.PostId.Visible = false;
            this.PostId.Width = 84;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.Frozen = true;
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 84;
            // 
            // btn_addPost
            // 
            this.btn_addPost.BackColor = System.Drawing.SystemColors.Info;
            this.btn_addPost.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_addPost.Location = new System.Drawing.Point(10, 85);
            this.btn_addPost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btn_addPost.Name = "btn_addPost";
            this.btn_addPost.Size = new System.Drawing.Size(145, 67);
            this.btn_addPost.TabIndex = 9;
            this.btn_addPost.Text = "发帖";
            this.btn_addPost.UseVisualStyleBackColor = false;
            this.btn_addPost.Click += new System.EventHandler(this.btn_addPost_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Beige;
            this.flowLayoutPanel3.Controls.Add(this.btn_userinfo);
            this.flowLayoutPanel3.Controls.Add(this.btn_addPost);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(164, 168);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_type.Location = new System.Drawing.Point(179, 213);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(37, 15);
            this.label_type.TabIndex = 16;
            this.label_type.Text = "推荐";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.comboBox_postType);
            this.panel2.Controls.Add(this.comboBox_timeOrder);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox_searchInput);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.comboBox_priceOrder);
            this.panel2.Location = new System.Drawing.Point(182, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 198);
            this.panel2.TabIndex = 34;
            // 
            // comboBox_postType
            // 
            this.comboBox_postType.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox_postType.FormattingEnabled = true;
            this.comboBox_postType.Items.AddRange(new object[] {
            "出售",
            "求购"});
            this.comboBox_postType.Location = new System.Drawing.Point(558, 29);
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
            this.comboBox_timeOrder.Location = new System.Drawing.Point(387, 29);
            this.comboBox_timeOrder.Name = "comboBox_timeOrder";
            this.comboBox_timeOrder.Size = new System.Drawing.Size(113, 23);
            this.comboBox_timeOrder.TabIndex = 7;
            this.comboBox_timeOrder.Text = "按时间降序";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_search.Font = new System.Drawing.Font("黑体", 12F);
            this.btn_search.Location = new System.Drawing.Point(877, 142);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // textBox_searchInput
            // 
            this.textBox_searchInput.BackColor = System.Drawing.Color.SeaShell;
            this.textBox_searchInput.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox_searchInput.Location = new System.Drawing.Point(373, 142);
            this.textBox_searchInput.Name = "textBox_searchInput";
            this.textBox_searchInput.Size = new System.Drawing.Size(482, 36);
            this.textBox_searchInput.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 178);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
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
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "终止时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "起始时间";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(103, 89);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_end.TabIndex = 1;
            this.dateTimePicker_end.Value = new System.DateTime(2020, 6, 21, 0, 0, 0, 0);
            // 
            // dateTimePicker_begin
            // 
            this.dateTimePicker_begin.Location = new System.Drawing.Point(103, 28);
            this.dateTimePicker_begin.Name = "dateTimePicker_begin";
            this.dateTimePicker_begin.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_begin.TabIndex = 0;
            this.dateTimePicker_begin.Value = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.textBox_maxPrice);
            this.tabPage2.Controls.Add(this.textBox_minPrice);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "价格区间";
            // 
            // textBox_maxPrice
            // 
            this.textBox_maxPrice.Location = new System.Drawing.Point(138, 92);
            this.textBox_maxPrice.Name = "textBox_maxPrice";
            this.textBox_maxPrice.Size = new System.Drawing.Size(139, 25);
            this.textBox_maxPrice.TabIndex = 3;
            this.textBox_maxPrice.Text = "1000000";
            // 
            // textBox_minPrice
            // 
            this.textBox_minPrice.Location = new System.Drawing.Point(138, 27);
            this.textBox_minPrice.Name = "textBox_minPrice";
            this.textBox_minPrice.Size = new System.Drawing.Size(139, 25);
            this.textBox_minPrice.TabIndex = 2;
            this.textBox_minPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(35, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "最高价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(35, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "最低价格";
            // 
            // comboBox_priceOrder
            // 
            this.comboBox_priceOrder.BackColor = System.Drawing.Color.SeaShell;
            this.comboBox_priceOrder.FormattingEnabled = true;
            this.comboBox_priceOrder.Items.AddRange(new object[] {
            "按价格升序",
            "按价格降序"});
            this.comboBox_priceOrder.Location = new System.Drawing.Point(387, 84);
            this.comboBox_priceOrder.Name = "comboBox_priceOrder";
            this.comboBox_priceOrder.Size = new System.Drawing.Size(113, 23);
            this.comboBox_priceOrder.TabIndex = 5;
            this.comboBox_priceOrder.Text = "按价格升序";
            // 
            // btn_allPosts
            // 
            this.btn_allPosts.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_allPosts.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_allPosts.Location = new System.Drawing.Point(21, 186);
            this.btn_allPosts.Name = "btn_allPosts";
            this.btn_allPosts.Size = new System.Drawing.Size(139, 39);
            this.btn_allPosts.TabIndex = 35;
            this.btn_allPosts.Text = "全部";
            this.btn_allPosts.UseVisualStyleBackColor = false;
            this.btn_allPosts.Click += new System.EventHandler(this.btn_allPosts_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.Frozen = true;
            this.titleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 66;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.Frozen = true;
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.Frozen = true;
            this.typeDataGridViewTextBoxColumn.HeaderText = "所属分区";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 96;
            // 
            // postTypeDataGridViewTextBoxColumn
            // 
            this.postTypeDataGridViewTextBoxColumn.DataPropertyName = "PostType";
            this.postTypeDataGridViewTextBoxColumn.Frozen = true;
            this.postTypeDataGridViewTextBoxColumn.HeaderText = "帖子类型";
            this.postTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postTypeDataGridViewTextBoxColumn.Name = "postTypeDataGridViewTextBoxColumn";
            this.postTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.postTypeDataGridViewTextBoxColumn.Width = 96;
            // 
            // postBindingSource
            // 
            this.postBindingSource.AllowNew = false;
            this.postBindingSource.DataSource = typeof(HunterClient.EntityClass.Post);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_allPosts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主页";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
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

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_userinfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Button btn_addPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_postType;
        private System.Windows.Forms.ComboBox comboBox_timeOrder;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_searchInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_begin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_maxPrice;
        private System.Windows.Forms.TextBox textBox_minPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_priceOrder;
        private System.Windows.Forms.Button btn_allPosts;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn btn_collect;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
    }
}

