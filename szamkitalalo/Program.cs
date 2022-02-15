using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int alsohatar = 1,
                felsohatar = 11,
                gondoltszam,
                tipp,
                tippalsohatar,
                tippfelsohatar,
                probal = 5;

            char valasz;
            bool eltalalta = false;
            Random rnd = new Random();

            do
            {
                Console.WriteLine("gondolsz?(i/n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    gondoltszam = rnd.Next(alsohatar, felsohatar);

                    for (int i = 0; i <= probal; i++)
                    {
                        Console.WriteLine("\nTippeljen");
                        tipp = int.Parse(Console.ReadLine());

                        if (gondoltszam < tipp)
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }
                        else if (gondoltszam > tipp)
                        {
                            Console.WriteLine("Nagyobb a gondolt szám");
                        }
                        else
                        {
                            Console.WriteLine("Gratulálok eltalálta");
                            break;
                        }
                    }
                }
                else
                {
                    eltalalta = false;
                    tippalsohatar = alsohatar;
                    tippfelsohatar = felsohatar;

                    Console.WriteLine("gondolsz?(i/n)");
                    for (int i = 0; i <= probal; i++)
                    {
                        tipp = tippalsohatar + (tippfelsohatar - tippalsohatar) / 2;

                        Console.WriteLine("Az én tippem {0} \n játékos válasza (n: nagyobbra gondoltam; k: kisebbre gondoltam t: eltalálta", tipp);
                        
                        valasz = Console.ReadKey().KeyChar;

                        if (valasz == 'n')
                        {
                            Console.WriteLine("nagyobb számra gondoltam");
                            tippalsohatar = tipp;
                        }
                        else if (valasz == 'k')
                        {
                            Console.WriteLine("Kisebb a gondolt szám");
                            tippfelsohatar = tipp;
                        }
                        else
                        {
                            eltalalta = true;
                            Console.WriteLine("Gratulálok eltalálta");
                            break;
                        }
                    }

                    if (!eltalalta)
                    {
                        Console.WriteLine("Lejárt a tippek száma");
                    }

                }
                Console.WriteLine("Folytatjuk a játékot?");
                
                while(Console.ReadKey().KeyChar == 'i');
                {

                }
            }
           

            Console.ReadKey();
        }
    }
}
