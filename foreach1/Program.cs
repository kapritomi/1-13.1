using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach1
{
    class Lista
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            l.feltolt();
            l.asd();

            Console.ReadKey();
        }
    }
}
