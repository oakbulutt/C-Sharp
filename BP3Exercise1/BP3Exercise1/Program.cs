using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter PLN/EUR exchange rate:");
            float exchangeRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter amount of money:");
            float money = float.Parse(Console.ReadLine());
            Console.WriteLine("Press \"1\" EUR to PLN:\nPress \"2\" PLN to EUR:");
            byte exchanceDirection = byte.Parse(Console.ReadLine());
            switch (exchanceDirection)
            {
                case 1:
                    float sum = money / exchangeRate;
                    Console.WriteLine("New currency money amount is: "+ sum +"PLN");
                    break;
                case 2:
                    sum = money * exchangeRate;
                    Console.WriteLine("New currency money amount is: " + sum + "EUR");
                    break;
                default:
                    Console.WriteLine("Invalid operation..!");
                    break;
            }
            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
    }
}
