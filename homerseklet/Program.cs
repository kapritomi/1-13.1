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
            int[,] a = new int[31,2];
            string honap;
            int nap;
            int min = 0;
            int max = 0;

            Dictionary<string, int> honapok = new Dictionary<string, int> {
                {"Január", 1 },{"Február", 2},{"Március", 3},
                {"Április", 4},{"Május", 5},{"Június", 6},
                {"Július", 7},{"Augusztus",8},{"Szeptember",9},
                {"Október",10},{"November",11},{"December",12}
            };

            honap = Console.ReadLine();
            nap = Convert.ToInt32(Console.ReadLine());
            //Tavasz
            if(honapok[honap] >= 3 && honapok[honap] <= 5)
            {
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    a[i,0] = rnd.Next(-10,0);
                    a[i,1] = rnd.Next(0,20);
			    }
                double atlag = (a[nap,0]+a[nap,1])/2;
                Console.WriteLine("Este: {0} Nappal: {1} Átlag: {2}",a[nap,0],a[nap,1],atlag);
                
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    if(a[i,0] < min)
                    {
                        min = a[i,0];
                    }
			    }
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    if(a[i,0] < max)
                    {
                        max = a[i,1];
                    }
			    }
                Console.WriteLine("Este: {0} Nappal: {1} ",min,max);
            }
            

            Console.ReadKey();
        }
    }
}
