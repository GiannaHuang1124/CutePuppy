namespace Productlist
{
    partial class Product
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
            System.Windows.Forms.Button btn儲存修改;
            System.Windows.Forms.Button btn選取商品圖片;
            System.Windows.Forms.Button btn儲存商品;
            System.Windows.Forms.Button btn選取商品圖片2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox修改 = new System.Windows.Forms.GroupBox();
            this.groupBox新增 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            btn儲存修改 = new System.Windows.Forms.Button();
            btn選取商品圖片 = new System.Windows.Forms.Button();
            btn儲存商品 = new System.Windows.Forms.Button();
            btn選取商品圖片2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.groupBox修改.SuspendLayout();
            this.groupBox新增.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn儲存修改
            // 
            btn儲存修改.BackColor = System.Drawing.SystemColors.ButtonFace;
            btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn儲存修改.Location = new System.Drawing.Point(216, 33);
            btn儲存修改.Name = "btn儲存修改";
            btn儲存修改.Size = new System.Drawing.Size(115, 46);
            btn儲存修改.TabIndex = 8;
            btn儲存修改.Text = "儲存修改";
            btn儲存修改.UseVisualStyleBackColor = false;
            btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品圖片
            // 
            btn選取商品圖片.BackColor = System.Drawing.SystemColors.ButtonFace;
            btn選取商品圖片.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn選取商品圖片.Location = new System.Drawing.Point(15, 33);
            btn選取商品圖片.Name = "btn選取商品圖片";
            btn選取商品圖片.Size = new System.Drawing.Size(179, 46);
            btn選取商品圖片.TabIndex = 7;
            btn選取商品圖片.Text = "選取商品圖片";
            btn選取商品圖片.UseVisualStyleBackColor = false;
            btn選取商品圖片.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // btn儲存商品
            // 
            btn儲存商品.BackColor = System.Drawing.SystemColors.ButtonFace;
            btn儲存商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn儲存商品.Location = new System.Drawing.Point(216, 33);
            btn儲存商品.Name = "btn儲存商品";
            btn儲存商品.Size = new System.Drawing.Size(115, 46);
            btn儲存商品.TabIndex = 8;
            btn儲存商品.Text = "產品上架";
            btn儲存商品.UseVisualStyleBackColor = false;
            btn儲存商品.Click += new System.EventHandler(this.btn儲存商品_Click);
            // 
            // btn選取商品圖片2
            // 
            btn選取商品圖片2.BackColor = System.Drawing.SystemColors.ButtonFace;
            btn選取商品圖片2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn選取商品圖片2.Location = new System.Drawing.Point(15, 33);
            btn選取商品圖片2.Name = "btn選取商品圖片2";
            btn選取商品圖片2.Size = new System.Drawing.Size(179, 46);
            btn選取商品圖片2.TabIndex = 7;
            btn選取商品圖片2.Text = "選取商品圖片";
            btn選取商品圖片2.UseVisualStyleBackColor = false;
            btn選取商品圖片2.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(461, 625);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn清空欄位.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(372, 17);
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
            this.btn刪除資料.Location = new System.Drawing.Point(203, 17);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(150, 40);
            this.btn刪除資料.TabIndex = 5;
            this.btn刪除資料.Text = "商品下架";
            this.btn刪除資料.UseVisualStyleBackColor = false;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn資料搜尋.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn資料搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn資料搜尋.Location = new System.Drawing.Point(26, 17);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(150, 40);
            this.btn資料搜尋.TabIndex = 2;
            this.btn資料搜尋.Text = "商品搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = false;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "末端售價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "產品編號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "商品進價";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSellPrice.Location = new System.Drawing.Point(179, 152);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(309, 34);
            this.txtSellPrice.TabIndex = 14;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPName.Location = new System.Drawing.Point(179, 90);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(309, 34);
            this.txtPName.TabIndex = 13;
            // 
            // lblPID
            // 
            this.lblPID.BackColor = System.Drawing.Color.Wheat;
            this.lblPID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPID.Location = new System.Drawing.Point(179, 33);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(195, 33);
            this.lblPID.TabIndex = 12;
            this.lblPID.Text = "0000000000";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBuyPrice.Location = new System.Drawing.Point(179, 214);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(309, 34);
            this.txtBuyPrice.TabIndex = 16;
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(571, 90);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(418, 401);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 17;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(704, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "商品圖檔";
            // 
            // groupBox修改
            // 
            this.groupBox修改.BackColor = System.Drawing.Color.Lavender;
            this.groupBox修改.Controls.Add(btn儲存修改);
            this.groupBox修改.Controls.Add(btn選取商品圖片);
            this.groupBox修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox修改.Location = new System.Drawing.Point(42, 606);
            this.groupBox修改.Name = "groupBox修改";
            this.groupBox修改.Size = new System.Drawing.Size(341, 95);
            this.groupBox修改.TabIndex = 7;
            this.groupBox修改.TabStop = false;
            this.groupBox修改.Text = "商品資料修改";
            // 
            // groupBox新增
            // 
            this.groupBox新增.BackColor = System.Drawing.Color.Lavender;
            this.groupBox新增.Controls.Add(btn儲存商品);
            this.groupBox新增.Controls.Add(btn選取商品圖片2);
            this.groupBox新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox新增.Location = new System.Drawing.Point(42, 505);
            this.groupBox新增.Name = "groupBox新增";
            this.groupBox新增.Size = new System.Drawing.Size(341, 95);
            this.groupBox新增.TabIndex = 9;
            this.groupBox新增.TabStop = false;
            this.groupBox新增.Text = "商品上架";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(42, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "商品描述";
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(179, 274);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(345, 217);
            this.txt商品描述.TabIndex = 20;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 713);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox新增);
            this.Controls.Add(this.groupBox修改);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.RightToLeftLayout = true;
            this.Text = "商品後台管理系統";
            this.Load += new System.EventHandler(this.Product_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.groupBox修改.ResumeLayout(false);
            this.groupBox新增.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox修改;
        private System.Windows.Forms.GroupBox groupBox新增;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt商品描述;
    }
}

