using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP6Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for value of N:");
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i}: {sum}");
                    sum = sum + i + 1;
                }
            }
            else
                return;

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
