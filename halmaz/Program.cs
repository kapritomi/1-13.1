using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz
{

    class Halmaz
    {
        Random rnd = new Random();
         int szam;
         int[] a;
         int[] b;

        public Halmaz()
        {
            beker();
        }
        public void beker() 
        {
            Console.WriteLine("Számot:");
            this.szam = Convert.ToInt32(Console.ReadLine());
        }
        public void feltolt()
        {
            if (this.szam > 200)
            {
                this.szam = rnd.Next(100, 201);
            }
             a = new int[this.szam];
             b = new int[this.szam];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-100, 100);
                Console.WriteLine("A halmaz elemei: {0}", this.a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(-100, 100);
                Console.WriteLine("B halmaz elemei: {0}",this.b[i]);
            }
        }    
        public void csakaza()
        {
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
        }
        public void csakab()
        {
            int counter1=0;
            List<int> nemismetlodo1 = new List<int>();

                for (int i = 0; i < b.Length; i++)
			    {
                    for (int j = 0; j < a.Length; j++)
			        {
                        if(b[i] != a[j])
                        {
                            counter1++;
                        }
			        }
                    if(counter1 == a.Length)
                    {
                        nemismetlodo1.Add(b[i]);

                    }
                    counter1 = 0;
			    }
                foreach (var item in nemismetlodo1)
	            {
                    Console.WriteLine(item);
	            }
        }
        public void metszet()
        {
            for (int i = 0; i < a.Length; i++)
			    {
                    for (int j = 0; j < b.Length; j++)
			        {
                        if(a[i] == b[j])
                        {
                            Console.WriteLine("metszet: {0}",a[i]);
                        }
                       
			        }
			    }
        }
        public void unio()
        {
             var unio = a.Union(b);
             Console.WriteLine(String.Join(", ",unio));
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Halmaz h = new Halmaz();

           
            h.feltolt();
            Console.WriteLine("Csak az A halmaz elemei:");
            h.csakaza();
            Console.WriteLine("Csak a B halmaz elemei:");
            h.csakab();
            Console.WriteLine("A metszet elemei:");
            h.metszet();
            Console.WriteLine("Az unió elemei:");
            h.unio();


            Console.ReadKey();
        }
    }
}
