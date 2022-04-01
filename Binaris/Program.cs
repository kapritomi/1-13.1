using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {
        public Binaris() { }

        string szo;
        int counter = 0;
        public void Beker()
        {
            Console.WriteLine("Add meg aszámot:");
            this.szo = Console.ReadLine();
        }
        public void vizsgal()
        {
            for (int i = 0; i < this.szo.Length; i++)
            {
                if(szo[i] == '1')
                {
                    this.counter++;
                }
            }
            Console.WriteLine(this.counter);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Binaris b = new Binaris();

            b.Beker();
            b.vizsgal();



            Console.ReadKey();
        }
    }
}
