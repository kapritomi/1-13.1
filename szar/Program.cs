using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool repeat = true;
            Console.WriteLine("Adj meg egy számot:");
            while (repeat)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Adj meg egy számot:");
                    repeat = true;
                }
            }

            Console.ReadKey();
        }
    }
}
