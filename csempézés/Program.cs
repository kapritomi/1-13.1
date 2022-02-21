using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempézés
{
    class Program
    {
        static void Main(string[] args)
        {
            double szel;
            double mag;
            double csempe = 0.2*0.2;
            double terulet;

            Console.WriteLine("Szélesség:");
            szel = double.Parse(Console.ReadLine());

            Console.WriteLine("Magasság:");
            mag = double.Parse(Console.ReadLine());

            terulet = szel * mag / csempe;

            Console.WriteLine("{0} darab csempe szükséges.",terulet+terulet*0.1);

            Console.ReadKey();
        }
    }
}
