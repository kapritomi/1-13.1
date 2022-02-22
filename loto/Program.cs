using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();

            int[] tomb = new int[10];
            int counter = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = R.Next(1, 7);
                Console.WriteLine(tomb[i]);
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                if(i == 6)
                {
                    counter++;
                }
            }

            Console.WriteLine("Ennyi hatos van: {0}",counter);


                Console.ReadKey();
        }
    }
}
