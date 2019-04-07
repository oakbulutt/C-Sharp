using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please enter third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            if (a != b && a != c && b != c)
            {
                if (a > b && a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine($"{c} < {b} < {a}");
                    }
                    else
                    {
                        Console.WriteLine($"{b} < {c} < {a}");
                    }
                }
                else if (b > a && b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine($"{c} < {a} < {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} < {c} < {b}");
                    }
                }
                else
                {
                    if (a > b)
                    {
                        Console.WriteLine($"{b} < {a} < {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} < {b} < {c}");
                    }
                }
            }
            if(a == b || a == c || b == c)
            {
                if(a == b && a == c)
                {
                    Console.WriteLine($"All numbers given are equal..!\n{a} = {b} = {c}");
                }
                else if (a == b && a > c)
                {
                    Console.WriteLine($"{c} < {b} = {a}");
                }
                else if(a == b && a < c)
                {
                    Console.WriteLine($"{a} = {b} < {c}");
                }
                else if(b == c && b > a)
                {
                    Console.WriteLine($"{a} < {c} = {b}");
                }
                else if (b == c && b < a)
                {
                    Console.WriteLine($"{c} = {b} < {a}");
                }
                else if(a == c && a > b)
                {
                    Console.WriteLine($"{b} < {c} = {a}");
                }
                else
                {
                    Console.WriteLine($"{a} = {c} < {b}");
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
