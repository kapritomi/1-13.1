using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
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
     class Hexa
     {
        
        int szam1;
        public Hexa(int szam1) 
        {
            this.szam1 = szam1;
        }
        public void szamol()
        {
            Console.WriteLine(string.Format("{0:x}", szam1));
        }
     }
     class Oct
     {
        int szam2, quot, i = 1, j;
        int[] octalVal = new int[80];
        public Oct(int szam2) 
        {
            this.szam2 = szam2;
        }
     public void szamolas()
        {
            this.quot = this.szam2;
              while (this.quot!= 0) {
                 this.octalVal[i++] = this.quot % 8;
                 this.quot = this.quot / 8;
              }
              for (j = i - 1; j > 0; j--)
                 Console.Write(octalVal[j]);
                 Console.Read();
        }  
     }

    class Program
    {
        static void Main(string[] args)
        {
            int szamrednszer;
            Console.WriteLine("Add meg a számrendszert:");
            szamrednszer = Convert.ToInt32(Console.ReadLine());

            if(szamrednszer == 2)
            {
                Console.WriteLine("Adj meg egy tízes számrendszerbeli számot:");
                Kettes k = new Kettes(Convert.ToInt32(Console.ReadLine()));
                k.szamolo();
                Console.WriteLine(k.GetBinaris());
            }
            if(szamrednszer == 16)
            {
                Console.WriteLine("Adj meg egy tízes számrendszerbeli számot:");
                Hexa h = new Hexa(Convert.ToInt32(Console.ReadLine()));
                h.szamol();
            }
            if(szamrednszer == 8)
            {
                Console.WriteLine("Adj meg egy tízes számrendszerbeli számot:");
                Oct o = new Oct(Convert.ToInt32(Console.ReadLine()));
                o.szamolas();
            }

            Console.ReadKey();
        }
    }
}