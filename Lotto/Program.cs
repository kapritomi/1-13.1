using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        Random rnd = new Random();
        int[] szamok = new int[5];
        public void szam()
        {
            for (int i = 0; i < this.szamok.Length; i++)
            {
                this.szamok[i] = rnd.Next(1,90);
                Console.WriteLine(szamok[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lotto l = new Lotto();

            l.szam();

            Console.ReadKey();
        }
    }
}
