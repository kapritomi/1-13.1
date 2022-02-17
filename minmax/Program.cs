using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            
            Random r = new Random();
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0, 100);
                Console.WriteLine(tomb[i]);
            }
            int min = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            int max = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            int minIndex = Array.IndexOf(tomb, tomb.Min());
            int maxIndex = Array.IndexOf(tomb, tomb.Max());

            Console.WriteLine("A legkisebb elem: {0}", min);
            Console.WriteLine("A legnagyobb elem: {0}", max);
            Console.WriteLine("A legkisebb elem indexe: {0}", minIndex);
            Console.WriteLine("A legnagyobb elem indexe: {0}", maxIndex);
            Console.ReadKey();
        }
    }
}
