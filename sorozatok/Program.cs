using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorozatok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elem = new int[4];
            int kulonb;
            int counter = 0;
            int counter1 = 0;
            Console.WriteLine("Add meg a 4 számot:");
            for (int i = 0; i < 4; i++)
            {
                elem[i] = Convert.ToInt32(Console.ReadLine());
            }
            kulonb = elem[1] - elem[0];

            for (int i = 1; i < elem.Length; i++)
            {
                if(elem[i] - elem[i-1] == kulonb)
                {
                    counter++;
                }
                else
                {
                    counter1++;   
                }
            }

           if(counter == 3)
            {
                Console.WriteLine("Sorozat");
            }
            else
            {
                Console.WriteLine("nem sorozat");
            }
           


            Console.ReadKey();
        }
    }
}
