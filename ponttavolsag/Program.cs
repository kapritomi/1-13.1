using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponttavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, y1, y2;

            Console.WriteLine("Add meg az x1-et:");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az x2-et:");
            x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az y1-et:");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az y2-et:");
            y2 = float.Parse(Console.ReadLine());



            Console.WriteLine(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));

            Console.ReadKey();
        }
    }
}
