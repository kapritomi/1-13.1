using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    public class Hengerr
    public class Henger
    {
        double sugar;
        double magas;
        public Hengerr() {
            this.sugar = 5;
            this.magas = 5;
        }
        public void getSugar()
        public Henger() { }
        
        public void setSugar()
        {
            this.sugar = Convert.ToInt32(Console.ReadLine());
            this.sugar = Convert.ToDouble(Console.ReadLine());
        }
        public void getMagas()
        public void setMagas()
        {
            this.magas = Convert.ToInt32(Console.ReadLine());
            this.magas = Convert.ToDouble(Console.ReadLine());
        }
        public double getKerulet()
        {
            return Math.Round(this.sugar * 2 * Math.PI,2);
            return this.sugar * 2 * Math.PI;
        }
        public double getTerulet()
        {
            return this.sugar * this.sugar * Math.PI;
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
            Hengerr h = new Hengerr();
            h.getSugar();
            h.getMagas();
            Console.WriteLine(h.getKerulet());
            Console.WriteLine(h.getTerulet());
            Console.WriteLine(h.getFelszin());
            Console.WriteLine(h.getTerfogat());
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
