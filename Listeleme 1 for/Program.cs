using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_algoritma_ödevim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 5; i++)
            {
                if (i%2 ==1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("1  2  3  4  5");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("#  #  #  #  # ");
                }
            }
            Console.ReadLine();
        }
    }
}
