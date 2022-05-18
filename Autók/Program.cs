using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autók
{
    internal class Autok
    {
        private class Autolista
        {
            private string rendszam;
            private string gyart;
            private string tipus;
            private DateTime gyartas;
            private DateTime muszaki;
            private string tulaj;

            public Autolista() { }

            public Autolista(string rendszam, string gyart, string tipus, DateTime gyartas, DateTime muszaki, string tulaj)
            {
                this.rendszam = rendszam;
                this.gyart = gyart;
                this.tipus = tipus;
                this.gyartas = gyartas;
                this.muszaki = muszaki;
                this.tulaj = tulaj;
            }

            public void printAuto()
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", rendszam, gyart, tipus, gyartas, muszaki, tulaj);
            }

            private List<Autolista> Kocsilista;

            private string fajlNev;

            public Autok()
            {
                Kocsilista = new List<Autolista>();
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

                        Kocsilista.Add(new Autolista(
                            mezok[0],
                            mezok[1],
                            mezok[2],
                            DateTime.Parse(mezok[3]),
                            DateTime.Parse(mezok[4]),
                            mezok[3]));
                    }
            }

            public void Kiir()
            {
                foreach (Autolista p in Kocsilista)
                {
                    p.printAuto();
                }
                Console.ReadKey();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Autok a = new Autok();
            a.Beolvas();
            a.Kiir();
        }
    }
}
