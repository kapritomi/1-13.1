using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double suly, bmi;
            int magassag;

            Console.WriteLine("Testsúly");
            suly = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Magasság");
            magassag = Convert.ToInt32(Console.ReadLine());

            bmi = Math.Round(suly / (magassag * magassag)*10000,2);

            Console.WriteLine(bmi);


            Console.ReadKey();
        }
    }
}
