using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veletlenszam
{
    public partial class Form1 : Form
    {
        public int db = 0,
            osszeg,
            min = int.MaxValue,
            max = int.MinValue;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Label lb = new Label();

            lb.Location = new Point(e.X, e.Y);
            int randomszam = rnd.Next(1, 101);
            lb.Text = Convert.ToString(randomszam);
            Controls.Add(lb);
            db++;
            osszeg += randomszam;

            if (randomszam < min)
            {
                min = randomszam;
            }
            if(randomszam > max)
            {
                max = randomszam;
            }
            double atlag = osszeg / db;

            label1.Text = String.Format("A számok összege {0}, a kattintások száma: {1}, az átlaguk: {2}, a minimum értékük: {3}, a maximum értékük: {4}",osszeg,db,atlag,min,max);

        }
    }
}
