using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Városok
{
    class Varosok
    {
        int szam;
        string varos;
        string varos1;
        List<string> varosok = new List<string>();
        public Varosok()
        {

        }
        public void setDb()
        {
            
            Console.WriteLine("Hány város legyen:");
            this.szam = Convert.ToInt32(Console.ReadLine());

            if (this.szam == 0)
            {
                this.szam = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void setNevek()
        {
            for (int i = 0; i < this.szam; i++)
            {
                Console.WriteLine("Város neve:");
                this.varosok.Add(Console.ReadLine());
            }
        }
        public void getNevek()
        {
            foreach (var item in this.varosok)
            {
                Console.Write(item + ",");
            }
        }
        public void getVan()
        {
            Console.WriteLine("Add meg egy város nevét:");
            this.varos = Console.ReadLine();

            foreach (var item in this.varosok)
            {
                if(this.varos == item)
                {
                    Console.WriteLine("Szerepel a listában");
                    break;
                }
                else
                {
                    Console.WriteLine("Nem szerepel a listában");
                }
            }
        }
        public void delNev()
        {
            Console.WriteLine("Add meg egy város nevét:");
            this.varos1 = Console.ReadLine();

            foreach (var item in this.varosok)
            {
                if (this.varos1 == item)
                {
                    this.varosok.Remove(varos1);
                    break;
                }
                else
                {
                    this.varosok.Add(this.varos1);
                }
            }
        }
        public void delLast()
        {
            this.varosok.RemoveAt(this.varosok.Count - 1);
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Varosok v = new Varosok();

            v.setDb();
            v.setNevek();
            v.getNevek();
            v.getVan();
            v.delNev();
            v.delLast();

            Console.ReadKey();
        }
    }
}
