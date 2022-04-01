using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        string binaris;
        int szam;
        int[] a = new int[] {128,64,32,16,8,4,2,1};
        public Kettes(int szam) 
        {
            this.szam = szam;
            this.binaris = "";
        }
        public void szamolo()
        {
            for (int i = 0; i < this.a.Length; i++)
            {
                if (this.szam - this.a[i] >= 0)
                {
                    this.binaris += "1";
                    this.szam -= this.a[i];
                }
                else
                {
                    this.binaris += "0";
                }
            }
        }
        public string GetBinaris()
        {
            return this.binaris;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy tízes számrendszerbeli számot:");
            Kettes k = new Kettes(Convert.ToInt32(Console.ReadLine()));

            k.szamolo();
            Console.WriteLine(k.GetBinaris());

            Console.ReadKey();
        }
    }
}
