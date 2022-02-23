using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = rnd.Next(5, 10), paros=0, paratlan=0;
            int[] tomb = new int[N];


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("számot:");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
                if(tomb[i] % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
            }
            Console.WriteLine("{0} páros szám van",paros);
            Console.WriteLine("{0} páratlan szám van",paratlan);

            Console.ReadKey();
        }
    }
}
