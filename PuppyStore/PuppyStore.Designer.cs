namespace PuppyStore
{
    partial class PuppyStore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuppyStore));
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.listView商品 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listView商品展示.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.LabelEdit = true;
            this.listView商品展示.Location = new System.Drawing.Point(164, 65);
            this.listView商品展示.MultiSelect = false;
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(898, 439);
            this.listView商品展示.TabIndex = 2;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList產品圖檔.ImageStream")));
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList產品圖檔.Images.SetKeyName(0, "1.jpg");
            this.imageList產品圖檔.Images.SetKeyName(1, "2.jpg");
            this.imageList產品圖檔.Images.SetKeyName(2, "3.jpg");
            this.imageList產品圖檔.Images.SetKeyName(3, "4.jpg");
            this.imageList產品圖檔.Images.SetKeyName(4, "5.jpg");
            this.imageList產品圖檔.Images.SetKeyName(5, "6.jpg");
            this.imageList產品圖檔.Images.SetKeyName(6, "7.jpg");
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(12, 33);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "會員登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // listView商品
            // 
            this.listView商品.HideSelection = false;
            this.listView商品.Location = new System.Drawing.Point(219, 60);
            this.listView商品.Name = "listView商品";
            this.listView商品.Size = new System.Drawing.Size(515, 328);
            this.listView商品.TabIndex = 0;
            this.listView商品.UseCompatibleStateImageBehavior = false;
            // 
            // PuppyStore
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 496);
            this.Controls.Add(this.listView商品);
            this.Name = "PuppyStore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView listView商品;
    }
}

