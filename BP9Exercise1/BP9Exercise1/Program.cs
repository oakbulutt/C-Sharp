using System;
using System.Collections;
using System.Collections.Generic;

namespace BP9Exercise1
{
    /*
     * Write a program that reads three numbers from the keyboard.
     * The first number is the first element of an arithmetic series.
     * The second, which has to be larger than zero, is the difference between consecutive elements in the series.
     * The third number is the number of elements to calculate (larger or equal to 1). 
     * 
     * After the numbers are entered generate the requested number of elements in the series and count how many times each digit is present in the calculated elements.
     * 
     * Hint: use an array of 10 integers or a Dictionary<char, int> to count the digits.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Char, int> counters = new Dictionary<Char, int>();

            int[] userInput = collectUserInput();

            foreach (Char character in arythmeticSeries(userInput))
            {
                if (!counters.ContainsKey(character))
                {
                    counters[character] = 1;
                }
                else
                {
                    counters[character] = counters[character] + 1;
                }
            }
            foreach (KeyValuePair<Char, int> item in counters)
            {
                Console.WriteLine("{0} X {1}", item.Key, item.Value);
            }

            Console.WriteLine("Press any key to exit..!");
            Console.ReadKey();
        }
        #region Check If The Input Is An Integer 
        static bool isNum(string x)
        {
            try
            {
                Convert.ToInt32(x);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation.. Entered variables must be integer");
                return false;
            }
        }
        #endregion

        #region Collect User Input
        static int [] collectUserInput()
        {
            int[] input = new int[3];
            input[1] = 1;
            input[2] = 1;
            
            for (int i = 0; i < input.Length; i++)
            {
                do
                {
                    Console.Write($"Enter number #{i + 1}: ");
                    string tempNum = Console.ReadLine();
                    if (isNum(tempNum) == true)
                    {
                        input[i] = int.Parse(tempNum);
                    }
                    else
                        break;
                } while (validateUserInput(input) == false);
            }
            return input;
        }
        #endregion

        #region Validate User Input
        static bool validateUserInput(int[] a)
        {
            while (true)
            {
                if (a[1] <= 0)
                {
                    Console.WriteLine("Second number must be greater or equal to 0..!");
                    return false;
                }
                else if (a[2] < 1)
                {
                    Console.WriteLine("Third number must be greater than 1..!");
                    return false;
                }
                else
                    break;
            }
            return true;
        }
        #endregion

        #region Create Arythmetic Series
        static char[] arythmeticSeries(int[] a)
        {
            int[] num = new int[a[2]];
            num[0] = a[0];
            for (int i = 1; i < a[2]; i++)
            {
                num[i] = a[0] += a[1];
            }
            Console.WriteLine("Arythmetic Series:");
            foreach (int item in num)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n---------------------------");
            string s = "";
            foreach (int item in num)
            {
                s += item.ToString();
            }
            char[] c = s.ToCharArray();
            return c;
        }
        #endregion

    }
}