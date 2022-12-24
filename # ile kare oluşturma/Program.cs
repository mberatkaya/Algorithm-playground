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
            int a, i;


            Console.Write("Kare Uzunluk ve Genişlik Birimi Giriniz = ");
            sayi = Convert.ToInt16(Console.ReadLine());

            for (a = 1; a <= sayi; a++)
            {
                Console.WriteLine("\n");

                for (i = 1; i <= sayi; i++) 
                {
                    Console.Write("  # ");                   
                }
            }
            Console.ReadLine();

        }
    }
}
