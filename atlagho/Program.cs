using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlagho
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] asd = new int[12,30];
            int min, max;
            min = asd[0, 0];
            max = asd[0, 0];
            

            for (int i = 0; i < asd.GetLength(0); i++)
            {
                Console.WriteLine("{0}: ",i+1);
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                    asd[i, j] = rnd.Next(-10, 31);
                    Console.Write(asd[i ,j]+" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                    
                    if (asd[i, j] > max)
                    {
                        max = asd[i, j];
                    }

                    
                    if (asd[i, j] < min)
                    {
                        min = asd[i, j];
                    }

                }

            }
    
            Console.WriteLine("Maximum element:" + max);
            Console.WriteLine("Minimum  element:" + min);





            Console.ReadKey();

            
        }
    }
}
