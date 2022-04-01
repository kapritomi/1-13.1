using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        public Menu() { }

        public void menu()
        {
            Console.WriteLine("Menüpontok: \n 1 Első menüpont \n 2 második menüpont \n 3 Harmadik menüpont \n 4 Negyedik menüpont \n 5 Kilépés");

            int szam;
            szam = Convert.ToInt32(Console.ReadLine());
            switch (szam)
            {
                case 1:
                    Console.WriteLine("Ez az egyes menüpont");
                    break;
                case 2:
                    Console.WriteLine("Ez a kettes menüpont");
                    break;
                case 3:
                    Console.WriteLine("Ez a hármas menüpont");
                    break;
                case 4:
                    Console.WriteLine("Ez a négyes menüpont");
                    break;
                case 5:
                    break;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();


            m.menu();


            Console.ReadKey();
        }
    }
}
