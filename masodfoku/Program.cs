using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfoku
{
    class Program
    {
        static void Main(string[] args)
        {
            //b*b-4*a*c
            float a;
            float b;
            float c;

            Console.WriteLine("A:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("B:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("C:");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine(b*b-4*a*c);

            Console.ReadKey();

        }
    }
}
