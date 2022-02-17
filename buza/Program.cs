using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buza
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            float buza;
            float hozam;
            int szorzo;
            Console.WriteLine("Elvetett búza mennyisége:");
            buza = float.Parse(Console.ReadLine());
            szorzo = rnd.Next(5, 16);
            
            hozam = buza * szorzo;
            Console.WriteLine(hozam);

            if(szorzo >= 5 && szorzo <= 8)
            {
                Console.WriteLine("Átlag alatti hozam");
            }
            else if (szorzo >= 9 && szorzo <= 12)
            {
                Console.WriteLine("Átlagos hozam");
            }
            else if (szorzo >= 13 && szorzo <= 15)
            {
                Console.WriteLine("Átlag feletti hozam");
            }
            Console.ReadKey();
        }
    }
}
