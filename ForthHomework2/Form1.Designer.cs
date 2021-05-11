namespace ForthHomework2
{
    partial class Mins
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
            this.hourBox = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(76, 56);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(100, 25);
            this.hourBox.TabIndex = 0;
            this.hourBox.Tag = "hour";
            this.hourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(182, 66);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(39, 15);
            this.hour.TabIndex = 1;
            this.hour.Text = "hour";
            this.hour.Click += new System.EventHandler(this.hour_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "mins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F);
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入时间（24小时制）";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Mins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.hourBox);
            this.Name = "Mins";
            this.Text = "mins";
            this.Load += new System.EventHandler(this.Mins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

