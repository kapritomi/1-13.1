using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulátor
{
    public class Kalkulator
    {
        double szam1;
        double szam2;
        char muv;
        double eredm;

        public Kalkulator() { }

        public void beker()
        {
            Console.WriteLine("Add meg a számot:");
            szam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add meg a másik számot:");
            szam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add meg a műveletjelet:");
            muv = Convert.ToChar(Console.ReadLine());
        }

        public double muvelet()
        {
            if(this.muv == '+')
            {
                eredm =  szam1 + szam2;
            }
            if(this.muv == '-')
            {
                eredm = szam1 - szam2;
            }
            if(this.muv == '*')
            {
                eredm = szam1 * szam2;
            }
            if(this.muv == '/')
            {
                eredm = szam1 / szam2;
            }
            return eredm;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
