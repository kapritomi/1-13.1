using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class Henger
    {
        double sugar;
        double magas;
        public Henger() { }
        
        public void setSugar()
        {
            this.sugar = Convert.ToDouble(Console.ReadLine());
        }
        public void setMagas()
        {
            this.magas = Convert.ToDouble(Console.ReadLine());
        }
        public double getKerulet()
        {
            return this.sugar * 2 * Math.PI;
        }
        public double getTerulet()
        {
            return (this.sugar * this.sugar) * Math.PI;
        }
        public double getFelszin()
        {
            return 2 * Math.PI * this.sugar * (this.sugar + this.magas);
        }
        public double getTerfogat()
        {
            return Math.PI * (this.sugar * this.sugar) * this.magas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Henger h = new Henger();

            h.setSugar();
            h.setMagas();
            Console.WriteLine("Kerület: "+h.getKerulet());
            Console.WriteLine("Terület: "+h.getTerulet());
            Console.WriteLine("Felszín: "+h.getFelszin());
            Console.WriteLine("Térfogat: "+h.getTerfogat());

            Console.ReadKey();
        }
    }
}
