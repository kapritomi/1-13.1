using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{

    class Kor
    {
        double sugar;
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

    
    class Program
    {
        static void Main(string[] args)
        {
            Kor k = new Kor();
            Console.WriteLine("Add meg a sugarat:");
            k.szamolo();
            Console.WriteLine("A kör területe: {0}, A kerülete: {1}", k.teruletszamolo(),k.keruletszamolo());

            Console.ReadKey();
        }
    }
}
