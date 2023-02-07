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
                    string TcNumber = Console.ReadLine();
                    if (IsTcNoValid(TcNumber))
                    {
                        Console.WriteLine(TcNumber + " numaralı Tc gerçektir");
                    }
                    else
                    {
                        Console.WriteLine(TcNumber + " numaralı Tc sahtedir");
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
                Console.WriteLine("TC Kimlik No 11 karakter olmalıdır.");
                return false;
            }

            bool isNumber = long.TryParse(tcNo, out long tcNumber);
            if (!isNumber)
            {
                Console.WriteLine("TC Kimlik No sadece rakamlardan oluşmalıdır.");
                return false;
            }

            if (tcNo[0] == '0')
            {
                Console.WriteLine("TC Kimlik No ilk hanesi 0 olamaz.");
                return false;
            }

            int firstDigit = (int)(tcNumber / 1000000000 % 10);
            int secondDigit = (int)(tcNumber / 100000000 % 10);
            int thirdDigit = (int)(tcNumber / 10000000 % 10);
            int fourthDigit = (int)(tcNumber / 1000000 % 10);
            int fifthDigit = (int)(tcNumber / 100000 % 10);
            int sixthDigit = (int)(tcNumber / 10000 % 10);
            int seventhDigit = (int)(tcNumber / 1000 % 10);
            int eighthDigit = (int)(tcNumber / 100 % 10);
            int ninthDigit = (int)(tcNumber / 10 % 10);
            int tenthDigit = (int)(tcNumber % 10);

            int mod10 = ((firstDigit + thirdDigit + fifthDigit + seventhDigit + ninthDigit) * 7 - (secondDigit + fourthDigit + sixthDigit + eighthDigit)) % 10;
            if (mod10 == tenthDigit)
            {
                Console.WriteLine("TC Kimlik No geçersizdir (4. kural).");
                return false;
            }

            int total = firstDigit + secondDigit + thirdDigit + fourthDigit + fifthDigit + sixthDigit + seventhDigit + eighthDigit + ninthDigit + tenthDigit;
            int mod11 = total % 10;
            if (mod11 == (int)(tcNumber / 10 % 10))
            {
                Console.WriteLine("TC Kimlik No geçersizdir (5. kural).");
                return false;
            }

            return true;
        }
    }
}
