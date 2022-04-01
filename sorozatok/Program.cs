using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorozatok
{

    class Sorozat
    {
        public Sorozat() { }

        int[] elem = new int[4];
        int kulonb;
        int counter = 0;
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        

        public void Beker()
        {
            Console.WriteLine("Add meg a 4 számot:");
            for (int i = 0; i < 4; i++)
            {
                this.elem[i] = Convert.ToInt32(Console.ReadLine());
            }
            this.kulonb = this.elem[1] - this.elem[0];
            for (int i = 1; i < this.elem.Length; i++)
            {
                if(this.elem[i] - this.elem[i-1] == this.kulonb)
                {
                    this.counter++;
                }
                else
                {
                    this.counter1++;   
                }
            }
            if(this.counter == 3)
           {
               Console.WriteLine("Sorozat");
           }
           else
           {
                Console.WriteLine("nem sorozat");
           }
        }
        public void Mertan()
        {
            this.kulonb = this.elem[1] / this.elem[0];
            for (int i = 1; i < this.elem.Length; i++)
            {
                if(this.elem[i] / this.elem[i-1] == this.kulonb)
                {
                    this.counter2++;
                }
                else
                {
                    this.counter3++;   
                }
            }
            if(this.counter2 == 3)
           {
               Console.WriteLine("Sorozat");
           }
           else
           {
                Console.WriteLine("nem sorozat");
           }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Sorozat s = new Sorozat();
            
            s.Beker();
            s.Mertan();
            

           
           


            Console.ReadKey();
        }
    }
}
