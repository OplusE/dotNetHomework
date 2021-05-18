namespace homework8
{
    partial class Form2
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
            this.refresh_botton = new System.Windows.Forms.GroupBox();
            this.customer_label = new System.Windows.Forms.Label();
            this.customer_txt = new System.Windows.Forms.TextBox();
            this.goods_label = new System.Windows.Forms.Label();
            this.goods_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.delete_order_button = new System.Windows.Forms.Button();
            this.add_order_button = new System.Windows.Forms.Button();
            this.show_order = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSource = new System.Windows.Forms.BindingSource(this.components);
            this.refresh_botton.SuspendLayout();
            this.show_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_botton
            // 
            this.refresh_botton.Controls.Add(this.customer_label);
            this.refresh_botton.Controls.Add(this.customer_txt);
            this.refresh_botton.Controls.Add(this.goods_label);
            this.refresh_botton.Controls.Add(this.goods_txt);
            this.refresh_botton.Controls.Add(this.price_txt);
            this.refresh_botton.Controls.Add(this.price_label);
            this.refresh_botton.Controls.Add(this.id_txt);
            this.refresh_botton.Controls.Add(this.id_label);
            this.refresh_botton.Controls.Add(this.delete_order_button);
            this.refresh_botton.Controls.Add(this.add_order_button);
            this.refresh_botton.Dock = System.Windows.Forms.DockStyle.Top;
            this.refresh_botton.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refresh_botton.Location = new System.Drawing.Point(0, 0);
            this.refresh_botton.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_botton.Name = "refresh_botton";
            this.refresh_botton.Padding = new System.Windows.Forms.Padding(4);
            this.refresh_botton.Size = new System.Drawing.Size(998, 178);
            this.refresh_botton.TabIndex = 0;
            this.refresh_botton.TabStop = false;
            this.refresh_botton.Text = "订单信息";
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Location = new System.Drawing.Point(285, 123);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(97, 20);
            this.customer_label.TabIndex = 9;
            this.customer_label.Text = "customer";
            this.customer_label.Click += new System.EventHandler(this.customer_label_Click);
            // 
            // customer_txt
            // 
            this.customer_txt.Location = new System.Drawing.Point(399, 120);
            this.customer_txt.Name = "customer_txt";
            this.customer_txt.Size = new System.Drawing.Size(257, 30);
            this.customer_txt.TabIndex = 8;
            this.customer_txt.Text = "assistant";
            // 
            // goods_label
            // 
            this.goods_label.AutoSize = true;
            this.goods_label.Location = new System.Drawing.Point(318, 45);
            this.goods_label.Name = "goods_label";
            this.goods_label.Size = new System.Drawing.Size(64, 20);
            this.goods_label.TabIndex = 7;
            this.goods_label.Text = "goods";
            this.goods_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // goods_txt
            // 
            this.goods_txt.Location = new System.Drawing.Point(399, 39);
            this.goods_txt.Name = "goods_txt";
            this.goods_txt.Size = new System.Drawing.Size(257, 30);
            this.goods_txt.TabIndex = 6;
            this.goods_txt.Text = "nothing";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(82, 120);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(172, 30);
            this.price_txt.TabIndex = 5;
            this.price_txt.Text = "0";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(12, 123);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(64, 20);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "price";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(82, 39);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(172, 30);
            this.id_txt.TabIndex = 3;
            this.id_txt.Text = "2019";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(26, 42);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(31, 20);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "ID";
            // 
            // delete_order_button
            // 
            this.delete_order_button.Location = new System.Drawing.Point(719, 115);
            this.delete_order_button.Name = "delete_order_button";
            this.delete_order_button.Size = new System.Drawing.Size(182, 35);
            this.delete_order_button.TabIndex = 1;
            this.delete_order_button.Text = "删除订单";
            this.delete_order_button.UseVisualStyleBackColor = true;
            this.delete_order_button.Click += new System.EventHandler(this.delete_order_button_Click);
            // 
            // add_order_button
            // 
            this.add_order_button.Location = new System.Drawing.Point(719, 33);
            this.add_order_button.Name = "add_order_button";
            this.add_order_button.Size = new System.Drawing.Size(182, 36);
            this.add_order_button.TabIndex = 0;
            this.add_order_button.Text = "添加订单";
            this.add_order_button.UseVisualStyleBackColor = true;
            this.add_order_button.Click += new System.EventHandler(this.add_order_button_Click);
            // 
            // show_order
            // 
            this.show_order.BackColor = System.Drawing.Color.BurlyWood;
            this.show_order.Controls.Add(this.dataGridView1);
            this.show_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_order.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_order.Location = new System.Drawing.Point(0, 178);
            this.show_order.Name = "show_order";
            this.show_order.Size = new System.Drawing.Size(998, 383);
            this.show_order.TabIndex = 1;
            this.show_order.TabStop = false;
            this.show_order.Text = "订单明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(992, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderSource
            // 
            this.orderSource.DataSource = typeof(homework8.Order);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 561);
            this.Controls.Add(this.show_order);
            this.Controls.Add(this.refresh_botton);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "修改订单界面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.refresh_botton.ResumeLayout(false);
            this.refresh_botton.PerformLayout();
            this.show_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox refresh_botton;
        private System.Windows.Forms.GroupBox show_order;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderSource;
        private System.Windows.Forms.Label goods_label;
        private System.Windows.Forms.TextBox goods_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button delete_order_button;
        private System.Windows.Forms.Button add_order_button;
        private System.Windows.Forms.Label customer_label;
        private System.Windows.Forms.TextBox customer_txt;
    }
}