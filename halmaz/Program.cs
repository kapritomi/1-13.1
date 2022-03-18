using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz
{

    class Halmaz
    {
        public Halmaz()
        {

        }
        public void beker() 
        {
            
            int szam;
            Random rnd = new Random();
            Console.WriteLine("Számot:");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 200)
            {
                szam = rnd.Next(100, 201);
            }
            int[] a = new int[szam];
            int[] b = new int[szam];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-100, 100);
                Console.WriteLine("a tomb: {0}", a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(-100, 100);
                Console.WriteLine("b tomb: {0}",b[i]);
            }

            Console.WriteLine("a-b");
            int counter=0;
            List<int> nemismetlodo = new List<int>();

                for (int i = 0; i < a.Length; i++)
			    {
                    for (int j = 0; j < b.Length; j++)
			        {
                        if(a[i] != b[j])
                        {
                            counter++;
                        }
			        }
                    if(counter == a.Length)
                    {
                        nemismetlodo.Add(a[i]);

                    }
                    counter = 0;
			    }
                foreach (var item in nemismetlodo)
	            {
                    Console.WriteLine(item);
	            }
            

            Console.WriteLine("b-a");
            int counter1=0;
            List<int> nemismetlodo1 = new List<int>();

                for (int i = 0; i < a.Length; i++)
			    {
                    for (int j = 0; j < b.Length; j++)
			        {
                        if(b[i] != a[j])
                        {
                            counter1++;
                        }
			        }
                    if(counter1 == a.Length)
                    {
                        nemismetlodo1.Add(a[i]);

                    }
                    counter1 = 0;
			    }
                foreach (var item in nemismetlodo1)
	            {
                    Console.WriteLine(item);
	            }

                for (int i = 0; i < a.Length; i++)
			    {
                    for (int j = 0; j < b.Length; j++)
			        {
                        if(a[i] == b[j])
                        {
                            Console.WriteLine();
                        }
			        }
			    }


        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Halmaz h = new Halmaz();

            h.beker();


            Console.ReadKey();
        }
    }
}
