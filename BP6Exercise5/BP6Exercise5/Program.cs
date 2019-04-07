using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP6Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 100");
            int SecretNumber = new Random().Next(100) + 1;

            int counter = 0;

            while (guess != SecretNumber)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > SecretNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if(guess == SecretNumber)
                    {
                        Console.WriteLine("You've just found the number..!");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }

                catch
                {
                    Console.WriteLine("Guess must be a number");
                    counter--;
                }

                counter++;
            }
            Console.WriteLine("Congrats, it took you " + counter + " tries");
            Console.ReadLine();
        }
    }
}
