using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP4Exercise3
{
    class Program
    {
        static double RoundTowardsZero(double x)
        {
            double result = 0;
            if ((Math.Ceiling(x) - x) > 0.5)
            {
                result = Math.Floor(x);
                return result;
            }
            else if((Math.Ceiling(x) - x) <= 0.5)
            {
                result = Math.Ceiling(x);
                return result;
            }
            else
                return result;
        }
        static void Main(string[] args)
        {
            double a = 5.23;
            double b = 5.67;

            Console.WriteLine($"Round Towards Zero:\n" +
                $"BEFORE:\t AFTER:\n" +
                $"{a}\t {RoundTowardsZero(a)}");

            Console.WriteLine($"Round Towards Zero:\n" +
                $"BEFORE:\t AFTER:\n" +
                $"{b}\t {RoundTowardsZero(b)}");

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();

            
        }
    }
}
