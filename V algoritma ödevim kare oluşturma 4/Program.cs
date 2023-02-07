using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_algoritma_ödevim_kare_oluşturma_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j % 3 == 2)
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
