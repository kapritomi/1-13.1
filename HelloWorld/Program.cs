using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes1 = new byte[100];
            Random rnd = new Random();
            Console.WriteLine("Számot:");
            string elso = Console.ReadLine();
            int a = Convert.ToInt32(elso);

            Console.WriteLine(" másik számot Számot:");
            string masodik = Console.ReadLine();
            int b = Convert.ToInt32(masodik);

            int eredmeny = a * b;

            if (a == 0 || b == 0)
            {
                Console.WriteLine("asd");
                
            }
               


            Console.WriteLine(eredmeny);



            Console.ReadKey();
        }
    }
}
