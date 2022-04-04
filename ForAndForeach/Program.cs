using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    class forandforeach
    {
        int[] a = new int[10];
        Random rnd = new Random();
        public void feltolt()
        {
            for (int i = 0; i < this.a.Length; i++)
            {
                this.a[i] = rnd.Next(1, 50);
            }
        }
        public void forcikuls()
        {
            for (int i = 0; i < this.a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void foreachh()
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            forandforeach f = new forandforeach();
            f.feltolt();
            Console.WriteLine("Forciklus:");
            f.forcikuls();
            Console.WriteLine("Foreach:");
            f.foreachh();


            Console.ReadKey();
        }
    }
}
