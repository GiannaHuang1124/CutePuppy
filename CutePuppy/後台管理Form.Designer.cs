namespace CutePuppy
{
    partial class 後台管理Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(後台管理Form));
            this.btn商品管理系統 = new System.Windows.Forms.Button();
            this.訂單維護系統 = new System.Windows.Forms.Button();
            this.btn顧客資料維護系統 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn商品管理系統
            // 
            this.btn商品管理系統.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn商品管理系統.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn商品管理系統.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn商品管理系統.Location = new System.Drawing.Point(3, 367);
            this.btn商品管理系統.Name = "btn商品管理系統";
            this.btn商品管理系統.Size = new System.Drawing.Size(361, 180);
            this.btn商品管理系統.TabIndex = 5;
            this.btn商品管理系統.Text = "商品管理系統";
            this.btn商品管理系統.UseVisualStyleBackColor = false;
            this.btn商品管理系統.Click += new System.EventHandler(this.btn商品管理系統_Click);
            // 
            // 訂單維護系統
            // 
            this.訂單維護系統.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.訂單維護系統.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.訂單維護系統.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.訂單維護系統.Location = new System.Drawing.Point(3, 186);
            this.訂單維護系統.Name = "訂單維護系統";
            this.訂單維護系統.Size = new System.Drawing.Size(361, 180);
            this.訂單維護系統.TabIndex = 4;
            this.訂單維護系統.Text = "訂單維護系統";
            this.訂單維護系統.UseVisualStyleBackColor = false;
            this.訂單維護系統.Click += new System.EventHandler(this.訂單維護系統_Click);
            // 
            // btn顧客資料維護系統
            // 
            this.btn顧客資料維護系統.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn顧客資料維護系統.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn顧客資料維護系統.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn顧客資料維護系統.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn顧客資料維護系統.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn顧客資料維護系統.Location = new System.Drawing.Point(3, 0);
            this.btn顧客資料維護系統.Name = "btn顧客資料維護系統";
            this.btn顧客資料維護系統.Size = new System.Drawing.Size(361, 180);
            this.btn顧客資料維護系統.TabIndex = 3;
            this.btn顧客資料維護系統.Text = "顧客資料維護系統";
            this.btn顧客資料維護系統.UseVisualStyleBackColor = false;
            this.btn顧客資料維護系統.Click += new System.EventHandler(this.btn顧客資料維護系統_Click);
            // 
            // 後台管理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 553);
            this.Controls.Add(this.btn商品管理系統);
            this.Controls.Add(this.訂單維護系統);
            this.Controls.Add(this.btn顧客資料維護系統);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "後台管理Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "後台管理Form";
            this.Load += new System.EventHandler(this.後台管理Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn商品管理系統;
        private System.Windows.Forms.Button 訂單維護系統;
        private System.Windows.Forms.Button btn顧客資料維護系統;
    }
}