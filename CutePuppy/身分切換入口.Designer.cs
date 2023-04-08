namespace CutePuppy
{
    partial class 身分切換入口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(身分切換入口));
            this.btn我是員工 = new System.Windows.Forms.Button();
            this.btn我是顧客 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn我是員工
            // 
            this.btn我是員工.BackColor = System.Drawing.Color.SteelBlue;
            this.btn我是員工.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn我是員工.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn我是員工.Location = new System.Drawing.Point(32, 43);
            this.btn我是員工.Name = "btn我是員工";
            this.btn我是員工.Size = new System.Drawing.Size(297, 100);
            this.btn我是員工.TabIndex = 0;
            this.btn我是員工.Text = "我是員工";
            this.btn我是員工.UseVisualStyleBackColor = false;
            this.btn我是員工.Click += new System.EventHandler(this.btn我是員工_Click);
            // 
            // btn我是顧客
            // 
            this.btn我是顧客.BackColor = System.Drawing.Color.SteelBlue;
            this.btn我是顧客.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn我是顧客.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn我是顧客.Location = new System.Drawing.Point(32, 180);
            this.btn我是顧客.Name = "btn我是顧客";
            this.btn我是顧客.Size = new System.Drawing.Size(297, 100);
            this.btn我是顧客.TabIndex = 1;
            this.btn我是顧客.Text = "我是顧客";
            this.btn我是顧客.UseVisualStyleBackColor = false;
            this.btn我是顧客.Click += new System.EventHandler(this.btn我是顧客_Click);
            // 
            // 身分切換入口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 344);
            this.Controls.Add(this.btn我是顧客);
            this.Controls.Add(this.btn我是員工);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "身分切換入口";
            this.Text = "身分切換入口";
            this.Load += new System.EventHandler(this.身分切換入口_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn我是員工;
        private System.Windows.Forms.Button btn我是顧客;
    }
}