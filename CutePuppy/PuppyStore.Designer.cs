namespace CutePuppy
{
    partial class PuppyStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuppyStoreForm));
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.lbl會員姓名 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(2, 40);
            this.listView商品展示.MultiSelect = false;
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(1435, 592);
            this.listView商品展示.TabIndex = 2;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl會員姓名
            // 
            this.lbl會員姓名.AutoSize = true;
            this.lbl會員姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員姓名.Location = new System.Drawing.Point(1073, 9);
            this.lbl會員姓名.Name = "lbl會員姓名";
            this.lbl會員姓名.Size = new System.Drawing.Size(92, 25);
            this.lbl會員姓名.TabIndex = 5;
            this.lbl會員姓名.Text = "會員姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "你好!歡迎光臨PuppyStore";
            // 
            // PuppyStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1442, 773);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl會員姓名);
            this.Controls.Add(this.listView商品展示);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PuppyStoreForm";
            this.Text = "PuppyStore";
            this.Load += new System.EventHandler(this.PuppyStoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.Label lbl會員姓名;
        private System.Windows.Forms.Label label1;
    }
}