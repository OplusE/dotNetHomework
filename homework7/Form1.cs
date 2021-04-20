using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics graphics;
        double th1 ;
        double th2  ;
        double per1 ;
        double per2 ;
        double leng;
        int n;
        int a ;
        int b;
        int c;
        string color;

        public void setColor()
        {
            color = textBox7.Text;
            switch (color)
            {
                case "black":
                    a = 0;
                    b = 0;
                    c = 0;
                    break;
                case "blue":
                    a = 0;
                    b = 0;
                    c = 255;
                    break;
                case "green":
                    a = 0;
                    b = 255;
                    c = 0;
                    break;
                case "red":
                    a = 255;
                    b = 0;
                    c = 0;
                    break;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panel2.CreateGraphics();
            per1 = Convert.ToDouble(textBox1.Text);
            per2 = Convert.ToDouble(textBox2.Text);
            th1 = Convert.ToDouble(textBox3.Text)*Math.PI/180;
            th2 = Convert.ToDouble(textBox4.Text) * Math.PI / 180;
            leng = Convert.ToDouble(textBox5.Text);
            n = Convert.ToInt32(textBox6.Text);
            setColor();

            draw(n, 350, 310, leng, -Math.PI / 2);
            
        }

        void draw(int n, double x, double y, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x + leng * Math.Cos(th);
            double y1 = y + leng * Math.Sin(th);
            drawLine(x, y, x1, y1);
            draw(n - 1, x1, y1, per1 * leng, th + th1);
            draw(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x, double y, double x1, double y1)
        {
            Pen chosePen = new Pen(Color.FromArgb(a,b,c), 1);
            graphics.DrawLine(
                chosePen,
                (int)x, (int)y, (int)x1, (int)y1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
