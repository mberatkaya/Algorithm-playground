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
            for (int j = 0; j <= sayilar.Length - 2; j++)
            {
                for (int i = 0; i <= sayilar.Length - 2; i++)
                {
                    if (sayilar[i] > sayilar[i + 1])
                    {
                        sinir = sayilar[i + 1];
                        sayilar[i + 1] = sayilar[i];
                        sayilar[i] = sinir;
                    }
                }
            }
            Console.WriteLine("Sıralama:");
            foreach (int a in sayilar)
                Console.Write(a + " ");
            Console.Read();
        }
    }
}
