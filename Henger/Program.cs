using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class Hengerr
    {
        double sugar;
        double magas;
        public Hengerr() {
            this.sugar = 5;
            this.magas = 5;
        }
        public void getSugar()
        {
            this.sugar = Convert.ToInt32(Console.ReadLine());
        }
        public void getMagas()
        {
            this.magas = Convert.ToInt32(Console.ReadLine());
        }
        public double getKerulet()
        {
            return Math.Round(this.sugar * 2 * Math.PI,2);
        }
        public double getTerulet()
        {
            return this.sugar * this.sugar * Math.PI;
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
            Hengerr h = new Hengerr();
            h.getSugar();
            h.getMagas();
            Console.WriteLine(h.getKerulet());
            Console.WriteLine(h.getTerulet());
            Console.WriteLine(h.getFelszin());
            Console.WriteLine(h.getTerfogat());

            Console.ReadKey();
        }
    }
}
