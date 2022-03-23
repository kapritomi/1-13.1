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
            double hoatlag = 0;

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
                    a[i,0] = rnd.Next(-2,10);
                    a[i,1] = rnd.Next(10,28);
			    }
                double atlag = (a[nap,0]+a[nap,1])/2;
                Console.WriteLine("NAPI: Min: {0} Max: {1} Átlag: {2}",a[nap,0],a[nap,1],atlag);
                
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    if(a[i,0] < min)
                    {
                        min = a[i,0];
                    }
			    }
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    if(a[i,1] > max)
                    {
                        max = a[i,1];
                    }
			    }
                for (int i = 0; i < a.GetLength(0); i++)
			    {
                    hoatlag = hoatlag +a[i,0];
                    hoatlag = hoatlag + a[i,1];
			    }
                hoatlag = hoatlag/ (a.Length*2);
                Console.WriteLine("HAVI: Min: {0} Max: {1} Átlag: {2}",min,max,Math.Round(hoatlag,2));
           


            }
            

            Console.ReadKey();
        }
    }
}
