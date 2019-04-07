using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP4Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the status of the banking account of the customer:");
            Console.WriteLine("1. Debt Account");
            Console.WriteLine("2. Low Account");
            Console.WriteLine("3. High Account");
            int acctStat = int.Parse(Console.ReadLine());
            switch (acctStat)
            {
                case 1:
                    Console.WriteLine("Is the customer working? (yes/no)");
                    string workingStatus = Console.ReadLine();
                    if(workingStatus == "yes" || workingStatus == "YES" || workingStatus == "Yes")
                    {
                        Console.WriteLine("Grant credit.");
                    }
                    else if(workingStatus == "no" || workingStatus == "NO" || workingStatus == "No")
                    {
                        Console.WriteLine("Why is the customer not working? (Retired/Lost Job)");
                        string reasonNotWorking = Console.ReadLine();
                        if(reasonNotWorking == "Retired" || reasonNotWorking == "RETIRED" || reasonNotWorking == "retired")
                        {
                            Console.WriteLine("Grant Credit.");
                        }
                        else if(reasonNotWorking == "Lost Job" || reasonNotWorking == "LOST JOB" || reasonNotWorking == "lost job")
                        {
                            Console.WriteLine("Reject the application..!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid operation..!\nPress any key to exit..!");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation..!\nPress any key to exit..!");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Enter credit amount:");
                    double creditAmount = double.Parse(Console.ReadLine());
                    if(creditAmount <= 5000)
                    {
                        Console.WriteLine("Grant Credit.");
                    }
                    else
                    {
                        Console.WriteLine("Reject the application..!");
                    }
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Grant Credit.");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid operation..!");
                    Console.WriteLine("Press any key to exit..!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
