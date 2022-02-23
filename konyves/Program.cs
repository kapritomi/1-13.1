using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyves
{
    class Program
    {
        static void Main(string[] args)
        {
            string cim;
            int oldal;

            Console.WriteLine("Add meg a könyv címét");
            cim = Console.ReadLine();

            Console.WriteLine("Add meg a könyv oldalainak számát");
            oldal = Convert.ToInt32(Console.ReadLine());


            if(oldal > 150)
            {
                Console.WriteLine("A {0} rövid terjedelmű könyv.",cim);
            }
            else if(oldal < 150)
            {
                Console.WriteLine("A {0} hosszú terjedelmű könyv.", cim);
            }

            Console.ReadKey();
        }
    }
}
