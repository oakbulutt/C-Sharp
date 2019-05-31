using System;

namespace BP12Exercise4
{
    class Program
    {
        delegate double ArithmaticDelegate(double x, double y);
        static void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("+ Addition");
            Console.WriteLine("- Subtraction");
            Console.WriteLine("* Multiplication");
            Console.WriteLine("/ Division");
            Console.WriteLine("% Remainder");
            Console.WriteLine("^ Exponentiate");
            Console.WriteLine("Q Quit");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Modulus(double a, double b)
        {
            return a % b;
        }
        static double Exponentiate(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static void Main(string[] args)
        {
            char operation;
            ArithmaticDelegate arithmatic = null;
            double x, y;

            do
            {
                Menu();
                operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    //Addition
                    case '+':
                        arithmatic = new ArithmaticDelegate(Add);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    //Subtraction
                    case '-':
                        arithmatic = new ArithmaticDelegate(Subtract);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    //Multiplication
                    case '*':
                        arithmatic = new ArithmaticDelegate(Multiply);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    //Division
                    case '/':
                        arithmatic = new ArithmaticDelegate(Divide);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    //Remainder
                    case '%':
                        arithmatic = new ArithmaticDelegate(Modulus);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    //Exponentiate
                    case '^':
                        arithmatic = new ArithmaticDelegate(Exponentiate);
                        Console.WriteLine("Enter two numbers seperated by Enter");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine(arithmatic(x, y));
                        break;
                    default:
                        Console.WriteLine("Exiting program");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();
            } while (char.ToUpper(operation) != 'Q');
        }
    }
}
