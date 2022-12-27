using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 2, 6, 3, 1, 5, 9, 7, 8 };
            int sinir;
            for (int i = 0; i <= sayilar.Length - 2; i++)
            {
                for (int j = 0; j <= sayilar.Length - 2; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        sinir = sayilar[j + 1];
                        sayilar[j + 1] = sayilar[j];
                        sayilar[j] = sinir;
                    }
                }
            }
            Console.WriteLine("Sıralama:");
            foreach (int k in sayilar)
                Console.Write(k + " ");
            Console.Read();
        }
    }
}
