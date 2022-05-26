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

            switch(s *3 + o)
            {
                case 0: lblfull.TextAlign = ContentAlignment.TopLeft; break;
                case 1: lblfull.TextAlign = ContentAlignment.TopCenter; break;
                case 2: lblfull.TextAlign = ContentAlignment.TopRight; break;
                case 3: lblfull.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: lblfull.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: lblfull.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: lblfull.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: lblfull.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: lblfull.TextAlign = ContentAlignment.BottomRight; break;
                
            }
        }
    }
}
