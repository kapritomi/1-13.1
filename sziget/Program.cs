using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sziget
{
    public class Sziget
    {
        int islandCount = 0;
        int maxIslandLength = 0;
        int i = 0;
        string data = "010111110000101";

        public Sziget() { }

        public int szigetszam()
        {
            while (i < data.Length)
            { 
                if (data[i] == '1') 
                { 
                    ++islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < data.Length && data[j] == '1')
                    { 
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) 
                    { 
                        maxIslandLength = tmp; 
                    }
                } else 
                { 
                    ++i;
                } 
            }
            return islandCount; 
        }

        public int szigethossz()
        {
            while (i < data.Length)
            { 
                if (data[i] == '1') 
                { 
                    ++islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < data.Length && data[j] == '1')
                    { 
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) 
                    { 
                        maxIslandLength = tmp; 
                    }
                } else 
                { 
                    ++i;
                } 
            }
            return maxIslandLength; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sziget s = new Sziget();
            Console.WriteLine(s.szigethossz());
            Console.WriteLine(s.szigetszam());

            Console.ReadKey();
        }
    }
}
