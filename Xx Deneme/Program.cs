using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xx_Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int i, j;


            Console.Write("Kare Uzunluk ve Genişlik Birimi Giriniz = ");
            sayi = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= sayi; i++)
            {
                Console.WriteLine("\n");

                for (j = 1; j <= sayi; j++) 
                {
                    Console.Write("  # ");                   
                }
            }
            Console.ReadLine();

        }
    }
}
