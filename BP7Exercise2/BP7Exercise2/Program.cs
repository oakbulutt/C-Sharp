using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP7Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num = collectUserInput();
            double arithmeticAverage = arithmeticMean(num);
            aboveBelowAverage(arithmeticAverage, num);
            equalsToTheLargestAndTheSmallest(num);

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
        static bool isNum(string x)
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
        static ArrayList collectUserInput()
        {
            ArrayList num = new ArrayList();
            int counter = 1;
            while (true)
            {
                Console.Write($"Enter number #{counter}: ");
                string tempNum = Console.ReadLine();
                if (isNum(tempNum) == true)
                {
                    num.Add(Convert.ToDouble(tempNum));
                    counter++;
                }
                else
                    break;
            }
            return num;
        }
        static double arithmeticMean(ArrayList num)
        {
            double sum = 0;
            double arithmeticMean = 0;
            foreach(double value in num)
            {
                sum += value;
                arithmeticMean = sum / num.Count;
            }
            Console.WriteLine($"Arithmetic Mean: {arithmeticMean}");
            return arithmeticMean;
        }
        static void aboveBelowAverage(double average, ArrayList num)
        {
            int aboveAverage = 0;
            int belowAverage = 0;
            foreach(double value in num)
            {
                if (value < average)
                    belowAverage++;
                else if (value > average)
                    aboveAverage++;
                else
                    continue;
            }
            Console.WriteLine($"{aboveAverage} numbers are larger than arithmetic mean.");
            Console.WriteLine($"{belowAverage} numbers are smaller than arithmetic mean.");
        }
        static void equalsToTheLargestAndTheSmallest(ArrayList num)
        {
            num.Sort();
            double theSmallest = double.Parse(Convert.ToString(num[0]));
            double theLargest = double.Parse(Convert.ToString(num[num.Count - 1]));

            int equalsToTheLargest = 0;
            int equalsToTheSmallest = 0;

            foreach (double value in num)
            {
                if (value == theLargest)
                    equalsToTheLargest++;
                else if (value == theSmallest)
                    equalsToTheSmallest++;
                else
                    continue;
            }
            Console.WriteLine($"The largest number is: {theLargest}");
            Console.WriteLine($"The smallest number is: {theSmallest}");

            Console.WriteLine($"{equalsToTheLargest} numbers are equal to the largest number.");
            Console.WriteLine($"{equalsToTheSmallest} numbers are equal to the smallest number.");
        }

    }
}

