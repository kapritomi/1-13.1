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
            int[,] a = new int[30,4];
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
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    for (int j = 0; j < a.GetLength(1); j++)
			        {
                        a[i,j] = rnd.Next(-10,20);
                        Console.WriteLine(a[i,j]);
			        }
                    
                    
			    }
            }


            Console.ReadKey();
        }
    }
}
