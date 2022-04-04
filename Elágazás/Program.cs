using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elágazás
{
    class Elagazas
    {
        Random rnd = new Random();
        List<int> parts = new List<int>();
        int hossz;

        public void feltolt()
        {
            this.hossz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < this.hossz; i++)
            {
                this.parts.Add(rnd.Next(10, 100));
            }
        }
        public void asd()
        {
            foreach (var item in this.parts)
            {
                Console.WriteLine(item);
            }
        }
        public void vizsgal()
        {
            foreach (var item in this.parts)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elagazas e = new Elagazas();
            e.feltolt();
            e.asd();
            Console.WriteLine();
            e.vizsgal();

            Console.ReadKey();

        }
    }
}
