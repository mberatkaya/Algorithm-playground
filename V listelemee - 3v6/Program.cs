using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_listelemee___3v6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i + j == 4)
                    {
                        Console.Write("* ");
                    }
                    else 
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
