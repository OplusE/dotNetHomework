using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForthHomework2
{
    public partial class Mins : Form
    {
        public Mins()
        {
            InitializeComponent();
        }

        private void hour_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mins_Load(object sender, EventArgs e)
        {

        }
    }
    public class SetTime:Mins
    {
        int hour;
        int mins;
        public void setTime(int hour, int mins)
        {
            hour = 0;
            mins = 0;

        }
    }
}
