using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            orderSource.DataSource = Form1.orderService.orderlist;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_label_Click(object sender, EventArgs e)
        {

        }

        private void add_order_button_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(id_txt.Text);
            string name = goods_txt.Text;
            string customer = customer_txt.Text;
            int price = Int32.Parse(price_txt.Text);
            Order order = new Order(id,price,name,customer);
            Form1.orderService.Create(order);
            orderSource.ResetBindings(false);
        }

        private void delete_order_button_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(id_txt.Text);
            var targetId = from n in Form1.orderService.orderlist
                           where n.id == id
                           select n;
            foreach(var n in targetId) { Form1.orderService.Delete(id); }
        }

    }
}
