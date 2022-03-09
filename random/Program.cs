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
        protected int darab;

        public Vektor() 
        { 
            this.beker();
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

    class Matrix: Vektor
    {
        
        int [,] matrix;

        public Matrix(): base()
        {
            matrix = new int[this.darab,this.darab];
        }
        public void tombos()
        {
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
			{
                for (int j = 0; j < matrix.GetLength(1); j++)
			    {
                   matrix[i,j]= rnd.Next(1,20);
                   Console.Write("{0}, ",matrix[i,j]);
			    }
                Console.WriteLine();
			}

        }
        public void Max()
        {
            int max = matrix.Cast<int>().Max(); 
            Console.WriteLine(max);
        }
        public void Min()
        {
            int min = matrix.Cast<int>().Min(); 
            Console.WriteLine(min);
        }
        public double atlagos()
        {
            double counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
			{
                for (int j = 0; j < matrix.GetLength(1); j++)
			    {
                    counter+= matrix[i,j];
			    }
			}
            return counter/(this.darab*2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix n = new Matrix();
           
            
            n.feltolt();
            Console.WriteLine("A számok átlaga:");
            Console.WriteLine(n.atlag());
            Console.WriteLine("Legkisebb elem:");
            n.min();
            Console.WriteLine("Legnagyobb elem");
            n.max();
            Console.WriteLine("matrix:");
            n.tombos();
            Console.WriteLine("Legnagyobb elem:");
            n.Max();
            Console.WriteLine("Legkisebb elem:");
            n.Min();
            Console.WriteLine("Átlag:{0}",n.atlagos());

            Console.ReadKey();
        }
    }
}
