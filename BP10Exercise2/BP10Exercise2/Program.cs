using System;

namespace BP10Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string input = Console.ReadLine();

            if (isPalindrome(input))
                Console.WriteLine("The text is a Palindrome");
            else
                Console.WriteLine("The text is not a Palindrome");
        }
        static bool isPalindrome(string a)
        {
            string b = a.ToUpper();
            if (b.Length <= 1)
                return true;
            else
            {
                if (b[0] != b[b.Length - 1])
                    return false;
                else
                    return isPalindrome(b.Substring(1, b.Length - 2));
            }
        }
    }
}
