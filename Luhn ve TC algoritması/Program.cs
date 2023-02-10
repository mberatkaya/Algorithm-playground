using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_ve_TC_algoritması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir işlem seçiniz...");
            Console.WriteLine("1. Luhn algoritması");
            Console.WriteLine("2. Tc kimlik algoritması");
            Console.WriteLine("3. Çıkış");
            Console.Write("İşleminiz: ");

            int seçim = Convert.ToInt32(Console.ReadLine());

            switch (seçim)
            {
                case 1:
                    Console.WriteLine("Luhn algoritması seçildi.");
                    Console.Write("Kredi kartı numaranızı giriniz: ");
                    string cardNumber = Console.ReadLine();

                    if (IsCrediCardValid(cardNumber))
                    {
                        Console.WriteLine(cardNumber + " numaralı Kredi kartı gerçektir.");
                    }
                    else
                    {
                        Console.WriteLine(cardNumber + " numaralı Kredi kartı sahtedir.");
                    }
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Tc kimlik algoritması seçildi.");
                    Console.Write("Tc kimlik numaranızı giriniz: ");
                    string tcNo = Console.ReadLine();
                    if (IsTcNoValid(tcNo))
                    {
                        Console.WriteLine(tcNo + " numaralı Tc gerçektir");
                    }
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Çıkış yapılıyor...");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim.Lütfen tekrar deneyiniz.");
                    Console.ReadLine();
                    break;
            }
        }
        public static bool IsCrediCardValid(string cardNumber)
        {
            int deg1 = 0;
            bool deg2 = false;
            if (cardNumber.Length !=16)
            {
                Console.WriteLine("Kart numarası 16 rakamdan oluşmalı");
                return false;
            }
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());
                if (deg2)
                {
                    n *= 2;
                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                deg1 += n;
                deg2 = !deg2;
            }
            return (deg1 % 10 == 0);
        }

        private static bool IsTcNoValid(string tcNo)
        {
            if (tcNo.Length != 11)
            {
                Console.WriteLine("Tc kimlik 11 haneli olmalıdır.");
                return false;
            }

            foreach (char c in tcNo)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Tc kimlik sadece rakamlardan oluşmalıdır.");
                    return false;
                }
            }
            if (tcNo[0] == '0')
            {
                Console.WriteLine("Tc kimlik 0 ile başlayamaz.");
                return false;
            }

            int[] numbers = new int[11];

            for (int i = 0; i < 11; i++)
            {
                numbers[i] = Int32.Parse(tcNo[i].ToString());
            }

            int toplam1 = 0;
            int toplam2 = 0;

            for (int i = 0; i < 10; i += 2)
            {
                toplam1 += numbers[i];
            }

            for (int i = 1; i < 11; i += 2)
            {
                toplam2 += numbers[i];
            }

            int mod1 = ((toplam1 * 7 - toplam2) % 10);
            if (mod1 != numbers[9])
            {
                return false;
            }

            int toplam3 = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam3 += numbers[i];
            }

            int mod2 = toplam3 % 10;
            if (mod2 != numbers[10])
            {
                return false;
            }
            return true;
        }
    }
}
