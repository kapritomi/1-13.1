using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill3
{
    class Matrix3
    {
        int[,] tomb;
        int a;
        int b;

        public Matrix3(int a, int b)
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
                    Console.WriteLine("Index: {0}", i);
                    this.tomb[i, j] = Convert.ToInt32(Console.ReadLine());
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
                    Console.Write(this.tomb[i, j]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorok/Oszlopok száma:");
            Matrix3 m = new Matrix3(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            m.feltolt();
            m.kiiras();


            Console.ReadKey();
        }
    }
}
