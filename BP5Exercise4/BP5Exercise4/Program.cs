using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP5Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter parameter N:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter parameter K:");
                int k = int.Parse(Console.ReadLine());
                int sum = 0;

                if (n >= 1 && k > 0 && k <= n)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % k == 0)
                        {
                            sum += i;
                        }
                        else
                            continue;
                    }
                    Console.WriteLine("Sum: " + sum);
                    break;
                }
                else
                    Console.WriteLine("Invalid parameters value..!\n" +
                        "N should be >= 1 and\n" +
                        "K should be > 0 and\n" +
                        "K should be <= N");
            }
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
