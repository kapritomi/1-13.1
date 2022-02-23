using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            int i = 0;
            int[] tomb = new int[10];
            Console.WriteLine("irj be egy számot:");
            szam = Convert.ToInt32(Console.ReadLine());

            while (szam != 0)
            {
                Console.WriteLine("irj be egy számot:");
                szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.WriteLine("A legnagyobb szám: {0}", tomb.Max());

            Console.ReadKey();
        }
    }
}
