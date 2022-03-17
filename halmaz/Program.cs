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
                a[i] = rnd.Next(-100, 101);
                Console.WriteLine(a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(-100, 101);
                Console.WriteLine(b[i]);
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
