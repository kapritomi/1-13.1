using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homerseklet
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[31];
            string honap;

            Dictionary<string, int> honapok = new Dictionary<string, int> {
                {"Január", 1 },{"Február", 2},{"Március", 3},
                {"Április", 4},{"Május", 5},{"Június", 6},
                {"Július", 7},{"Augusztus",8},{"Szeptember",9},
                {"Október",10},{"November",11},{"December",12}
            };

            honap = Console.ReadLine();
            //Tavasz
            if(honapok[honap] >= 3 && honapok[honap] <= 5)
            {
                for (int i = 0; i < a.Length; i++)
			    {
                    a[i] = rnd.Next(-10,0);
                    Console.WriteLine(a[i]);
			    }
            }


            Console.ReadKey();
        }
    }
}
