using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP3Exercise3
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);

            Swap(ref x, ref y);

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);

            Console.ReadKey();
        }
    }
}
