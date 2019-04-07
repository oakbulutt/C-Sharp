using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP6Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num = new ArrayList();
            double arithmeticMean = 0;
            double total = 0;
            while (true)
            {
                Console.WriteLine($"Enter number:");
                string tempNum = Console.ReadLine();

                if (IsEmpty(tempNum) == true && IsNum(tempNum) == true)
                {
                    num.Add(Convert.ToDouble(tempNum));
                }
                else
                    break;
            }
            foreach(double elements in num)
            {
                total += elements;
                arithmeticMean = total / num.Count;
            }

            Console.WriteLine("An arithmetic mean of the numbers is: " + arithmeticMean);

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();

        }
        static bool IsEmpty(string x)
        {
            if (x == "")
                return false;
            else
                return true;
        }
        static bool IsNum(string x)
        {
            try
            {
                Convert.ToDouble(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
