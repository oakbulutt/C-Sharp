using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP6Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for value of N:");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
