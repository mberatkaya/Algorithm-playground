using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Sıralama_algoirtması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sıralamak istediğiniz 3 değeer giriniz: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[3] {a, b, c};
            Array.Sort(numbers);

            Console.WriteLine("1.en büyük: " + numbers[2]);
            Console.WriteLine("2.en büyük: " + numbers[1]);
            Console.WriteLine("3.en büyük: " + numbers[0]);
            Console.ReadLine();
        }
    }
}
