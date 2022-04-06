using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill2
{
    class Matrix2
    {
        int[,] tomb;
        int a;
        int b;

        public Matrix2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void feltolt()
        {
            this.tomb = new int[this.a, this.b];
            for (int i = 0; i < this.tomb.GetLength(0); i++)
            {
                for (int j = 0; j < this.tomb.GetLength(1); j++)
                {
                    this.tomb[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (this.tomb.GetLength(1) == j+1)
                    {
                        this.sor(i);
                    }
                }
            }
        }
        public void kiiras()
        {
            for (int i = 0; i < this.tomb.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.tomb.GetLength(1); j++)
                {
                    Console.Write("{0} ",this.tomb[i, j]);
                }
            }
        }
        public void sor(int y)
        {
                for (int i = 0; i < this.tomb.GetLength(1); i++)
                {
                    Console.Write("{0} ", this.tomb[y, i]);
                }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorok/Oszlopok száma:");
            Matrix2 m = new Matrix2(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            m.feltolt();
            m.kiiras();

            Console.ReadKey();
        }
    }
}
