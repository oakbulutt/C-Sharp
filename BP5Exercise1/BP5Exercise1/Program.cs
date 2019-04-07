using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP5Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("For loop: "+sum);

            int a = 1;
            int result = 0;
            while (a <= 100)
            {
                result += a;
                a++;
            }
            Console.WriteLine("While loop: "+result);

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
