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
            int max = 0;

            do
            {
                Console.WriteLine("irj be egy számot:");
                szam = Convert.ToInt32(Console.ReadLine());
                if (max < szam)
                {
                    max = szam;
                }
            }
            while (szam != 0);
            
            {
                
            }
            Console.WriteLine("A legnagyobb szám: {0}", max);

            Console.ReadKey();
        }
    }
}
