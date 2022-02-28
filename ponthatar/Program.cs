using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponthatar
{
    class Program
    {
        static void Main(string[] args)
        {
            int eredmeny;

            Console.WriteLine("Írd be a pontszámot:");
            eredmeny = Convert.ToInt32(Console.ReadLine());

            if(eredmeny > 1 && eredmeny <= 50)
            {
                Console.WriteLine("1");
            }
            else if (eredmeny > 51 && eredmeny <= 65)
            {
                Console.WriteLine("2");
            }

            else if (eredmeny > 66 && eredmeny <= 80)
            {
                Console.WriteLine("3");
            }

            else if (eredmeny > 81 && eredmeny <= 90)
            {
                Console.WriteLine("4");
            }

            else if (eredmeny > 91)
            {
                Console.WriteLine("5");
            }

            Console.ReadKey();
        }
    }
}
