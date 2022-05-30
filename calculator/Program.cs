using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        double szam1;
        double szam2;
        char muvelet;
        double eredmeny1;
        public Calculator()
        {

        }
        public double eredmeny()
        {
            Console.WriteLine("elso szam:");
            this.szam1 = 10;
            Console.WriteLine("masosdik szam:");
            this.szam2 = 10;
            Console.WriteLine("muveleti jel:");
            this.muvelet = '+';
            
            if (muvelet == '+')
            {
                 this.eredmeny1=szam1 + szam2;
                
            }
            else if (muvelet == '-')
            {
                this.eredmeny1 = szam1 - szam2;
            }
            else if(muvelet=='*')
            {
                this.eredmeny1 = szam1 * szam2;
            }
            else if(muvelet=='/')
            {
                this.eredmeny1 = szam1 / szam2;
            }
            return this.eredmeny1;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator a = new Calculator();
            Console.WriteLine(a.eredmeny());

            Console.ReadKey();
        }
    }
}
