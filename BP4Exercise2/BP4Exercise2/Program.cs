using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP4Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the argument number1:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the argument number2:");
            int secondNumber = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("Choose the operation:\n" +
                "+\n-\n*\n/\n^");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case '^':
                    result = 1;
                    for(int i=0; i<secondNumber; i++)
                    {
                        result *= firstNumber;
                    }
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
