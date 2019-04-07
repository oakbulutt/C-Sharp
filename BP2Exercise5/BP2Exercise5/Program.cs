using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2Exercise5
{
    class Program
    {
        static int Fibonacci(int f)
        {
            if (f == 0) return 1;
            if (f == 1) return 1;
            else return Fibonacci(f - 1) + Fibonacci(f - 2);
        }
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
