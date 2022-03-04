using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{

    class Kor
    {
        private double sugar;
        public Kor()
        {

        }
        public double teruletszamolo()
        {
            return this.sugar * this.sugar * 3.14;
        }
        public double keruletszamolo()
        {
            return 2 * 3.14 * this.sugar;
        }

        public void szamolo()
        {
            this.sugar = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Henger : Kor
    {
        private double magassag;

        public Henger()
        {
            
        } 
        public void magassagszamolo()
        {
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }

        public double terfogat()
        {
            return this.teruletszamolo() *  this.magassag;
        }
    }


    
    class Program
    {
        static void Main(string[] args)
        {
            Henger a = new Henger();

            Console.WriteLine("Add meg a sugarat:");
            a.szamolo();
            Console.WriteLine("A kör területe: {0}, A kerülete: {1}", a.teruletszamolo(),a.keruletszamolo());
            a.magassagszamolo();
            Console.WriteLine("A henger térfogata:{0} Alapterülete: {1}",a.terfogat(),a.teruletszamolo());
            Console.ReadKey();
        }
    }
}
