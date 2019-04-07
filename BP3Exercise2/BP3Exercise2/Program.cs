using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP3Exercise2
{
    class Program
    {
        static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third number:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Min value: " + Min(a, b, c));
            Console.WriteLine("Max value: " + Max(a, b, c));
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
