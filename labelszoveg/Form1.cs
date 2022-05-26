using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelszoveg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfull.Text = "Kattints a képernyőn valahova";
        }
        private void lblfull_MouseClick(object sender, MouseEventArgs e)
        {
            int o = (int)e.X / (lblfull.Width / 3);
            int s = (int)e.Y / (lblfull.Height / 3);
        }
    }
}
