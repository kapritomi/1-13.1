using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szam
{
    class Oszthat
    {
        int szam;

        public void setSzam()
        {
            this.szam = Convert.ToInt32(Console.ReadLine());
            int num = -1;
            if (!int.TryParse(szam, out num))
            {
                Console.WriteLine("Not an integer");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
               

            Console.ReadKey();
        }
    }
}
