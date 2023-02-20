using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kalan;
            string sonuc = " ";
            Console.Write("2'li sayı sistemine çevirmek istediğniiz değeri giriniz: ");
            int deg1 = Convert.ToInt32(Console.ReadLine());

            while (deg1 !=0)
            {
                kalan = deg1 % 2;
                deg1 = deg1/ 2;
                sonuc = kalan + sonuc;
            }
            Console.WriteLine("2 li sayı sistemi karşılığı: " + sonuc);
            Console.ReadLine();
        }
    }
}
