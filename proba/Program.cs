using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Feladat
    {
        Random rnd = new Random();
        int elem;
        int elem1;
        int[] tomb;
        int[] tomb2;
        int a;
        int a1;
        int b;
        int b1;
        int counter = 0;
        double avg;
        int maxValue;
        int minValue;   

        public void beolvas()
        {
            Console.WriteLine("Add meg az elemszámot:");
            this.elem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a tartományt:");
            this.a = Convert.ToInt32(Console.ReadLine());
            this.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }
        public void feltolt()
        {
            this.tomb = new int[this.elem];
            for (int i = 0; i < this.tomb.Length; i++)
            {
                this.tomb[i] = rnd.Next(a,b);
                Console.WriteLine(this.tomb[i]);
            }
        }
        public void osszeg()
        {
            for (int i = 0; i < this.tomb.Length; i++)
            {
                this.counter += this.tomb[i];
            }
            Console.WriteLine("A számok összege: {0}",this.counter);
        }
        public void atlag()
        {
            this.avg = this.counter / this.elem;
            Console.WriteLine("A számok átlaga: {0}", this.avg);
        }
        public void maximum()
        {
            this.maxValue = this.tomb.Max();
            Console.WriteLine("A legnagyobb szám: {0}", this.maxValue);
        }
        public void minimum()
        {
            this.minValue = this.tomb.Min();
            Console.WriteLine("A legkisebb szám: {0}", this.minValue);
        }
        public void beolvas2()
        {
            Console.WriteLine("Add meg az elemszámot:");
            this.elem1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a tartományt:");
            this.a1 = Convert.ToInt32(Console.ReadLine());
            this.b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }
        public void feltolt2()
        {
            this.tomb2 = new int[this.elem1];
            for (int i = 0; i < this.tomb2.Length; i++)
            {
                this.tomb2[i] = rnd.Next(a1, b1);
                Console.WriteLine(this.tomb2[i]);
            }
        }

        public void compare()
        {
            for (int i = 0; i < tomb2.Length; i++)
            {
                if(this.tomb[i] != this.tomb2[i])
                {
                    this.tomb.Append(this.tomb2[i]);
                    Console.WriteLine(String.Join(",",this.tomb[i]));
                }
               
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat feladat = new Feladat();
            feladat.beolvas();
            feladat.feltolt();
            feladat.osszeg();   
            feladat.atlag();
            feladat.maximum();
            feladat.minimum();
            feladat.beolvas2();
            feladat.feltolt2();
            feladat.compare();
            Console.ReadKey();
        }
    }
}
