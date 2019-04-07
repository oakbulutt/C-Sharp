using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP7Exercise1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] userInput = collectUserInput();
            int sum = calculateSumOfNumbers(userInput);

            findIntegersInArray(sum, userInput);

            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }

        static int[] collectUserInput()
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number #{i + 1}:");
                num[i] = int.Parse(Console.ReadLine());
            }
            return num;
        }
        static int calculateSumOfNumbers(int[] num)
        {
            int sum = 0;
            foreach (int value in num)
            {
                sum += value;
            }
            return sum;
        }
        static void findIntegersInArray(int sum, int[] num)
        {
            foreach (int value in num)
            {
                if (sum % value == 0)
                {
                    Console.WriteLine("Value: " + value);
                }
            }
        }
    }
}
