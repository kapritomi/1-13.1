using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace percek
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan elso = new TimeSpan();
            TimeSpan masodik = new TimeSpan();

            Console.WriteLine("első időpont");
            elso = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("második időpont");
            masodik = TimeSpan.Parse(Console.ReadLine());

            if(elso > masodik)
            {
                Console.WriteLine("A különbség: {0}",elso - masodik);
            }
            else
            {
                Console.WriteLine("A különbség: {0}",masodik - elso);
            }

            

            Console.ReadKey();  
        }
    }
}
