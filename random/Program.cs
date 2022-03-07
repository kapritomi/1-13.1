using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Vektor
    {
        
        int[] tomb;
        int darab;


        public Vektor()
        { 
        
        }

        public void beker()
        {
            Console.WriteLine("Hány elemű legyen:");
            this.darab = Convert.ToInt32(Console.ReadLine());
            tomb = new int[this.darab];
            
        }
    

        public void feltolt()
        {
            Random rnd = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 20);
                Console.WriteLine(tomb[i]);
                
            }
        }

        public double atlag()
        {
            double counter = 0;


            for (int i = 0; i < tomb.Length; i++)
            {
                counter += tomb[i];
            }

            return counter / this.darab;
        }

        public void min()
        {
            Console.WriteLine(tomb.Min());
        }

        public void max()
        {
            Console.WriteLine(tomb.Max());
        }
       

       

    }


    class Program
    {
        static void Main(string[] args)
        {
            Vektor n = new Vektor();

            n.beker();
            n.feltolt();
            Console.WriteLine("A számok átlaga:");
            Console.WriteLine(n.atlag());
            Console.WriteLine("Legkisebb elem:");
            n.min();
            Console.WriteLine("Legnagyobb elem");
            n.max();



            Console.ReadKey();
        }
    }
}
