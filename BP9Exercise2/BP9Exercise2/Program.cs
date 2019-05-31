using System;
using System.Collections.Generic;

namespace BP9Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> personal = new Dictionary<long, string>();
            byte operation;
            long idNum = 100000;
            do
            {
                Console.Clear();
                Console.WriteLine("Please select the action you want to do:");
                Console.WriteLine("1. Add new person -------->");
                Console.WriteLine("2. Remove person --------->");
                Console.WriteLine("3. Modify personal data -->");
                Console.WriteLine("4. List of all data ------>");
                Console.WriteLine("5. Exit ------------------>");
                Console.Write("");
                //operation = Convert.ToByte(Console.ReadLine());

                if (byte.TryParse(Console.ReadLine(), out operation))
                {
                    Console.WriteLine();
                    switch (operation)
                    {
                        case 1:
                            Console.Write("Please enter personal name: ");
                            string personName = Console.ReadLine();
                            personal.Add(idNumber(ref idNum), personName);
                            break;
                        case 2:
                            Console.WriteLine("Please enter the id number of person who you want to remove:");
                            idNum = Convert.ToInt64(Console.ReadLine());
                            personal.Remove(idNum);
                            if (personal.Remove(idNum) == true)
                                Console.WriteLine("Data is removed!");
                            else
                                Console.WriteLine("Removing process is failed! ");
                            break;
                        case 3:
                            Console.WriteLine("Please enter the id number of person who you want to update:");
                            idNum = Convert.ToInt64(Console.ReadLine());
                            bool requiredtValue = personal.ContainsKey(idNum);
                            if (requiredtValue)
                            {
                                string value = personal[idNum];
                                Console.WriteLine("Enter the new data for change with :" + personal[idNum]);
                                value = Console.ReadLine();
                                personal[idNum] = value;
                            }
                            else
                                Console.WriteLine("Not Found!");
                            break;
                        case 4:
                            foreach (KeyValuePair<long, string> data in personal)
                            {
                                Console.WriteLine("Id Number: {0}\tName: {1}", data.Key, data.Value);
                            }
                            Console.Write("Press any key to continue..:");
                            Console.ReadKey();
                            break;
                        default:
                            if (operation != 5)
                            {
                                Console.WriteLine("Invalid Operation!");
                                break;
                            }
                            else
                                break;
                    }
                }
                else
                {
                    Console.Write("Invalid Operation!" +
                        "\nPress any key to continue..:");
                    Console.ReadKey();
                }
            } while (operation != 5);
        }
        //static long idNumber()
        //{
        //    Random num = new Random();
        //    long id = num.Next(0001, 9999);
        //    return id;
        //}
        static long idNumber(ref long id)
        {
            id ++;
            return id;
        }
        
    }
}
