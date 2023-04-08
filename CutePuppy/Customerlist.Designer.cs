namespace customerlist
{
    partial class FormMember
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn資料筆數 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv會員資料預覽 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btn訂單維護系統 = new System.Windows.Forms.GroupBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.listbox搜尋結果 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt欄位關鍵字 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBoxGender = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.btn商品管理系統 = new System.Windows.Forms.Button();
            this.btn到訂單維護系統 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料預覽)).BeginInit();
            this.btn訂單維護系統.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn新增資料);
            this.groupBox1.Controls.Add(this.btn資料修改);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Controls.Add(this.btn資料筆數);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(185, 663);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn清空欄位.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(780, 24);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(150, 40);
            this.btn清空欄位.TabIndex = 6;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn刪除資料.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn刪除資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.Location = new System.Drawing.Point(630, 24);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(150, 40);
            this.btn刪除資料.TabIndex = 5;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = false;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn新增資料.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn新增資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.Location = new System.Drawing.Point(480, 24);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(150, 40);
            this.btn新增資料.TabIndex = 4;
            this.btn新增資料.Text = " 新增資料";
            this.btn新增資料.UseVisualStyleBackColor = false;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn資料修改.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn資料修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.Location = new System.Drawing.Point(330, 24);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(150, 40);
            this.btn資料修改.TabIndex = 3;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = false;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn資料搜尋.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn資料搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn資料搜尋.Location = new System.Drawing.Point(180, 24);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(150, 40);
            this.btn資料搜尋.TabIndex = 2;
            this.btn資料搜尋.Text = "姓名搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = false;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // btn資料筆數
            // 
            this.btn資料筆數.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn資料筆數.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btn資料筆數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料筆數.Location = new System.Drawing.Point(30, 24);
            this.btn資料筆數.Name = "btn資料筆數";
            this.btn資料筆數.Size = new System.Drawing.Size(150, 40);
            this.btn資料筆數.TabIndex = 1;
            this.btn資料筆數.Text = "資料筆數";
            this.btn資料筆數.UseVisualStyleBackColor = false;
            this.btn資料筆數.Click += new System.EventHandler(this.btn資料筆數_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "會員編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "性別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(25, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(25, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "電話";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(131, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 35);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "00000000";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(334, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 33);
            this.label8.TabIndex = 28;
            this.label8.Text = "輸入姓名搜尋";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(136, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 30);
            this.txtName.TabIndex = 29;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(136, 269);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 30);
            this.txtPhone.TabIndex = 31;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBirthday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBirthday.Location = new System.Drawing.Point(136, 223);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(181, 34);
            this.dtpBirthday.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(136, 318);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(324, 30);
            this.txtAddress.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(136, 365);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 30);
            this.txtEmail.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dgv會員資料預覽);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(57, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1353, 180);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "會員資料預覽";
            // 
            // dgv會員資料預覽
            // 
            this.dgv會員資料預覽.BackgroundColor = System.Drawing.Color.White;
            this.dgv會員資料預覽.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv會員資料預覽.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料預覽.Location = new System.Drawing.Point(25, 50);
            this.dgv會員資料預覽.Name = "dgv會員資料預覽";
            this.dgv會員資料預覽.RowHeadersWidth = 51;
            this.dgv會員資料預覽.RowTemplate.Height = 27;
            this.dgv會員資料預覽.Size = new System.Drawing.Size(1301, 109);
            this.dgv會員資料預覽.TabIndex = 1;
            this.dgv會員資料預覽.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料預覽_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(22, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "分類搜尋";
            // 
            // btn訂單維護系統
            // 
            this.btn訂單維護系統.BackColor = System.Drawing.Color.Transparent;
            this.btn訂單維護系統.Controls.Add(this.btn搜尋);
            this.btn訂單維護系統.Controls.Add(this.listbox搜尋結果);
            this.btn訂單維護系統.Controls.Add(this.label13);
            this.btn訂單維護系統.Controls.Add(this.label12);
            this.btn訂單維護系統.Controls.Add(this.dtp結束時間);
            this.btn訂單維護系統.Controls.Add(this.dtp開始時間);
            this.btn訂單維護系統.Controls.Add(this.cbox欄位名稱);
            this.btn訂單維護系統.Controls.Add(this.txt欄位關鍵字);
            this.btn訂單維護系統.Controls.Add(this.label10);
            this.btn訂單維護系統.Controls.Add(this.label9);
            this.btn訂單維護系統.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單維護系統.Location = new System.Drawing.Point(736, 64);
            this.btn訂單維護系統.Name = "btn訂單維護系統";
            this.btn訂單維護系統.Size = new System.Drawing.Size(613, 391);
            this.btn訂單維護系統.TabIndex = 37;
            this.btn訂單維護系統.TabStop = false;
            this.btn訂單維護系統.Text = "進階搜尋";
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(371, 73);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(84, 30);
            this.btn搜尋.TabIndex = 46;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // listbox搜尋結果
            // 
            this.listbox搜尋結果.FormattingEnabled = true;
            this.listbox搜尋結果.ItemHeight = 29;
            this.listbox搜尋結果.Location = new System.Drawing.Point(27, 240);
            this.listbox搜尋結果.Name = "listbox搜尋結果";
            this.listbox搜尋結果.Size = new System.Drawing.Size(564, 149);
            this.listbox搜尋結果.TabIndex = 45;
            this.listbox搜尋結果.TabStop = false;
            this.listbox搜尋結果.SelectedIndexChanged += new System.EventHandler(this.listbox搜尋結果_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(44, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "終止日";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(44, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "起始日";
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Location = new System.Drawing.Point(141, 188);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(177, 34);
            this.dtp結束時間.TabIndex = 42;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Location = new System.Drawing.Point(141, 146);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(177, 34);
            this.dtp開始時間.TabIndex = 41;
            this.dtp開始時間.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // cbox欄位名稱
            // 
            this.cbox欄位名稱.FormattingEnabled = true;
            this.cbox欄位名稱.Location = new System.Drawing.Point(236, 73);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(118, 37);
            this.cbox欄位名稱.TabIndex = 40;
            // 
            // txt欄位關鍵字
            // 
            this.txt欄位關鍵字.Location = new System.Drawing.Point(27, 73);
            this.txt欄位關鍵字.Name = "txt欄位關鍵字";
            this.txt欄位關鍵字.Size = new System.Drawing.Size(203, 38);
            this.txt欄位關鍵字.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(33, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "生日搜尋";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cBoxGender);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.dtpBirthday);
            this.groupBox4.Controls.Add(this.txtPhone);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.lblID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(109, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 398);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "會員資料";
            // 
            // cBoxGender
            // 
            this.cBoxGender.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxGender.FormattingEnabled = true;
            this.cBoxGender.Location = new System.Drawing.Point(134, 128);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(121, 30);
            this.cBoxGender.TabIndex = 75;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(136, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 30);
            this.txtPassword.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(25, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "密碼";
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLoginInfo.Location = new System.Drawing.Point(961, 9);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(92, 25);
            this.lblLoginInfo.TabIndex = 39;
            this.lblLoginInfo.Text = "登入資訊";
            // 
            // btn商品管理系統
            // 
            this.btn商品管理系統.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理系統.Location = new System.Drawing.Point(185, 2);
            this.btn商品管理系統.Name = "btn商品管理系統";
            this.btn商品管理系統.Size = new System.Drawing.Size(171, 33);
            this.btn商品管理系統.TabIndex = 58;
            this.btn商品管理系統.Text = "商品管理系統";
            this.btn商品管理系統.UseVisualStyleBackColor = true;
            this.btn商品管理系統.Click += new System.EventHandler(this.btn商品管理系統_Click);
            // 
            // btn到訂單維護系統
            // 
            this.btn到訂單維護系統.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn到訂單維護系統.Location = new System.Drawing.Point(-5, 2);
            this.btn到訂單維護系統.Name = "btn到訂單維護系統";
            this.btn到訂單維護系統.Size = new System.Drawing.Size(193, 33);
            this.btn到訂單維護系統.TabIndex = 60;
            this.btn到訂單維護系統.Text = "訂單維護系統";
            this.btn到訂單維護系統.UseVisualStyleBackColor = true;
            this.btn到訂單維護系統.Click += new System.EventHandler(this.btn訂單維護系統_Click);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1442, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn到訂單維護系統);
            this.Controls.Add(this.btn商品管理系統);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn訂單維護系統);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顧客資料維護系統";
            this.Load += new System.EventHandler(this.FormMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料預覽)).EndInit();
            this.btn訂單維護系統.ResumeLayout(false);
            this.btn訂單維護系統.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Button btn資料筆數;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv會員資料預覽;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox btn訂單維護系統;
        private System.Windows.Forms.ListBox listbox搜尋結果;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt欄位關鍵字;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Button btn商品管理系統;
        private System.Windows.Forms.Button btn到訂單維護系統;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxGender;
    }
}

