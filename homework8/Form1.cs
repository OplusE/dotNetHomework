using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework8;

namespace homework8
{
    public partial class Form1 : Form
    {
        public static OrderService orderService;

        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            Order order1 = new Order(2019,21,"apple","Peter");
            Order order2 = new Order(2019,35, "orange", "Peter");
            Order order3 = new Order(2020,21, "apple", "Tom");
            Order order4 = new Order(2021, 25, "banana", "Kitty");
            orderService.Create(order1);
            orderService.Create(order2);
            orderService.Create(order3);
            orderService.Create(order4);
       
            orderSource.DataSource = orderService.orderlist;

        }
        public void refresh()
        {
            orderSource.DataSource = orderService.orderlist;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void search_order_button_Click(object sender, EventArgs e)
        {
            int s = Int32.Parse(txtSearch.Text);
            var targetId = from n in orderService.orderlist
                           where n.id == s
                           select n;
            orderSource.DataSource = targetId;
        }
        private void search_name_button_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            var targetName = from n in orderService.orderlist
                             where n.name == s
                             select n;
            orderSource.DataSource = targetName;
        }
        private void add_order_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            orderSource.ResetBindings(false);
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e){  }
        private void label1_Click(object sender, EventArgs e)  {   }

        private void txtSearch_TextChanged(object sender, EventArgs e){  }
        private void label2_Click(object sender, EventArgs e) {  }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
