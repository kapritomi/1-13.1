using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuletett
{
    class Program
    {
        static void Main(string[] args)
        {
            string nev, fog, nem="", teljes;
            Random rnd = new Random();
            string[] jo = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Add meg a nevet:");
                nev = Console.ReadLine();
                Console.WriteLine("Add meg a foglalkozást:");
                fog = Console.ReadLine();
                Console.WriteLine("Add meg a nemét(f/n):");
                nem = Console.ReadLine();
                if (nem == "f")
                {
                    nem = "Férfi";
                }
                else if( nem == "n")
                {
                    nem = "Nő";
                }
                teljes = nev + " egy " + fog +" "+ nem +" volt, szerencse száma a "+ rnd.Next(1, 50);
                jo[i] = teljes;
            }
            for (int i = 0; i < jo.Length; i++)
            {
                Console.WriteLine(jo[i]);
            }
            
            
            Console.ReadKey();
        }
    }
}
