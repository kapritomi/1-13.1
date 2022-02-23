using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    class Program
    {
        static void Main(string[] args)
        {
            int elso, masodik;

            Console.WriteLine("Add meg az első számot:");
            elso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a második számot:");
            masodik = Convert.ToInt32(Console.ReadLine());

            if (elso < 0 && masodik < 0)
            {
                Console.WriteLine("Mindkét szám negatív");
            }
            else if (elso < 0)
            {
                Console.WriteLine("A két szám közül az első negatív");
            }
            else if(masodik < 0)
            {
                Console.WriteLine("A két szám közül a második negatív");
            }
            else
            {
                Console.WriteLine("A két szám közül egyik sem negatív");
            }

            Console.ReadKey();
        }
    }
}
