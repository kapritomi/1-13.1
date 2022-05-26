using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetime
{
    public partial class Form1 : Form
    {
        int ev = 0;
        int honap = 0;
        int nap = 0;
        int ora = 0;
        int perc = 0;
        int masodperc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtbox.Text = string.Format("{0}:{1}:{2}", dtpicker.Value.Hour, dtpicker.Value.Minute, dtpicker.Value.Second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev = Convert.ToInt32(numericUpDown1.Value + dtpicker.Value.Year);
            label1.Text = string.Format("{0}.", ev);
        }
    }
}
