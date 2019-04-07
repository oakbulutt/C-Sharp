using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2Exercise4
{
    class Program
    {
        static int factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n = n * factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number for factorial calculation:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(input));
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
