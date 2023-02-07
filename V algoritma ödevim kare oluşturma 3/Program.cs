using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_algoritma_ödevim_kare_oluşturma_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i % 3 == 1)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
