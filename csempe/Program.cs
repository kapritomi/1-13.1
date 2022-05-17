using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempe
{
    public class Csempe
    {
        double szel;
        double mag;
        double csempe = 0.2 * 0.2;
        double terulet;
        public Csempe() {
            this.szel = 5;
            this.mag = 5;
        }
        public void setSzel()
        {
            this.szel = double.Parse(Console.ReadLine());
        }
        public void setMag()
        {
            this.mag = double.Parse(Console.ReadLine());
        }
        public double Eredm()
        {
            this.terulet = this.szel * this.mag / this.csempe;
            return Math.Round(terulet + terulet * 0.1,2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Csempe c = new Csempe();
            Console.WriteLine(c.Eredm());

            Console.ReadKey();
        }
    }
}
