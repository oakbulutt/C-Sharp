using System;

namespace BP10Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number which you want to convert to binary.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(findBinary(num));

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
        static int findBinary(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 2 + 10 * findBinary(number / 2));
        }
    }
}
