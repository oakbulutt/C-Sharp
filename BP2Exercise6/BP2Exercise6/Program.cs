using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2Exercise6
{
    class Program
    {
        static int GDC(int n, int k)
        {
            if (k == 0) return n;
            int remaining = n % k;
            if (remaining == 0) return k;
            return GDC(k, remaining);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter firs number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber <= secondNumber)
            {
                Console.WriteLine($"Greatest Common Diviser of {firstNumber} and {secondNumber} numbers: " +
                    $"{GDC(firstNumber, secondNumber)}\nPress any key to exit..!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid operation..!\nPress any key to exit..!");
                Console.ReadKey();
            }
        }
    }
}
