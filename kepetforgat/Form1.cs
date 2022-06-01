using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kepetforgat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image s = label7.Image;
            label7.Image = label8.Image;
            label8.Image = label6.Image;
            label6.Image = label5.Image;
            label5.Image = label4.Image;
            label4.Image = label11.Image;
            label11.Image = label10.Image;
            label10.Image = label9.Image;
            label9.Image = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image s = label7.Image;
            label7.Image = label9.Image;
            label9.Image = label10.Image;
            label10.Image = label11.Image;
            label11.Image = label4.Image;
            label4.Image = label5.Image;
            label5.Image = label6.Image;
            label6.Image = label8.Image;
            label8.Image = s;
        }
    }
}
