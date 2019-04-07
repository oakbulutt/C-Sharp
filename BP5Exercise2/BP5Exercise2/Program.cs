using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP5Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
