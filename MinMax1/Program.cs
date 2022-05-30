using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax1
{
    public class MinMax
    {
        int[] a = new int[] { 5, 4, 3, 10, 6 };

        public MinMax() { }

        public int min()
        {
            return a.Min();
        }
        public int max()
        {
            return a.Max();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinMax m = new MinMax();
            Console.WriteLine(m.min());
            Console.WriteLine(m.max());

            Console.ReadKey();
        }
    }
}
