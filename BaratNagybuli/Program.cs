using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratNagybuli
{
    internal class Baratlista
    {
        private class Barat
        {
            private string nev;
            private DateTime szuletett;
            private char neme;
            public int bulis;

            public Barat() { }

            public Barat(string nev, DateTime szuletett, char neme, int bulis)
            {
                this.nev = nev;
                this.szuletett = szuletett;
                this.neme = neme;
                this.bulis = bulis;
            }

            public void printBarat()
            {
                Console.WriteLine("{0,-20} {1,10} {2,1} {3}", nev, szuletett.ToShortDateString(), neme, bulis);
            }

            private List<Barat> baratLista;

            private string fajlNev;
            public Baratlista()
            {
                baratLista = new List<Barat>();
            }
            public void Beolvas()
            {
                string sor;
                string[] mezok;

                Console.WriteLine("Adja meg a szövegfájl nevét elérési úttal!");

                fajlNev = Console.ReadLine();
                if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";

                using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                    while (sr.EndOfStream == false)
                    {
                        sor = sr.ReadLine();
                        if (sor.Trim().Length == 0) continue;

                        mezok = sor.Split(',');

                        baratLista.Add(new Barat(
                            mezok[0],
                            DateTime.Parse(mezok[1]),
                            char.Parse(mezok[2]),
                            int.Parse(mezok[3])));
                    }
            }

            public void Kiir()
            {
                foreach (Barat p in baratLista)
                {
                    p.printBarat();
                }
                Console.ReadKey();
            }
        }


        static  void rendezes(List<Barat> bulizok)
        {
            for (int i = 0; i < bulizok.Count; i++)
            {
                for (int j = i + 1; j < bulizok.Count; j++)
                {
                    if (bulizok[i].bulis > bulizok[j].bulis)
                    {
                        Barat c = bulizok[i];
                        bulizok[i] = bulizok[j];
                        bulizok[j] = c;
                    }
                }
            }
        }


    internal class Program
    {
        static void Main(string[] args)
        {
            Baratlista bl = new Baratlista();
            bl.Beolvas();
            bl.Kiir();
        }
    }
}
