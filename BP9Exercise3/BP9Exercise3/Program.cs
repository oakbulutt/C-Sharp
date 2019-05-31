using System;
using System.Collections.Generic;
using System.Globalization;

namespace BP9Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionaryTurkish = new Dictionary<string, string>();
            Dictionary<string, string> dictionaryEnglish = new Dictionary<string, string>();

            #region Turkish to English Dictionary Data
            dictionaryTurkish.Add("Araba", "Car");
            dictionaryTurkish.Add("Masa", "Table");
            dictionaryTurkish.Add("Defter", "Notebook");
            dictionaryTurkish.Add("Klavye", "Keyboard");
            dictionaryTurkish.Add("Top", "Ball");
            dictionaryTurkish.Add("Üniversite", "University");
            dictionaryTurkish.Add("İnsan", "Human");
            dictionaryTurkish.Add("Hayvan", "Animal");
            #endregion

            #region English to Turkish Dictionary Data
            dictionaryEnglish.Add("Car", "Araba");
            dictionaryEnglish.Add("Table", "Masa");
            dictionaryEnglish.Add("Notebook", "Defter");
            dictionaryEnglish.Add("Keyboard", "Klavye");
            dictionaryEnglish.Add("Ball", "Top");
            dictionaryEnglish.Add("University", "Üniversite");
            dictionaryEnglish.Add("Human", "İnsan");
            dictionaryEnglish.Add("Animal", "Hayvan");
            #endregion
           
            byte operation;
            string turkish;
            string english;
            do
            {
                Console.Clear();
                Console.WriteLine("Please select the action you want to do:");
                Console.WriteLine("-------------------------\n| 1. Turkish to English |");
                Console.WriteLine("-------------------------\n| 2. English to Turkish |");
                Console.WriteLine("-------------------------\n| 3. Exit               |\n-------------------------");
                Console.Write("");
                if (byte.TryParse(Console.ReadLine(), out operation))
                {
                    switch (operation)
                    {
                        #region Turkish to English Switch Case
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------\n| 1. Search word            |");
                                Console.WriteLine("-----------------------------\n| 2. Add word               |");
                                Console.WriteLine("-----------------------------\n| 3. Remove word            |");
                                Console.WriteLine("-----------------------------\n| 4. List of all data       |");
                                Console.WriteLine("-----------------------------\n| 5. Check yourself (Test)  |");
                                Console.WriteLine("-----------------------------\n| 6. Home Page              |\n-----------------------------");
                                if (byte.TryParse(Console.ReadLine(), out operation))
                                {
                                    switch (operation)
                                    {
                                        case 1:
                                            Console.Write("Please enter the Turkish word: ");
                                            turkish = ToTitleCase(Console.ReadLine());
                                            try
                                            {
                                                Console.WriteLine("\n|Turkish: {0} ---> English: {1} |\n---------------------------------------\nPress any key to continue..", turkish, dictionaryTurkish[turkish]);
                                                Console.ReadKey();
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Not Found!\nPress any key to continue..");
                                                Console.ReadKey();

                                            }
                                            break;
                                        case 2:
                                            Console.Write("Please enter Turkish word: ");
                                            turkish = ToTitleCase(Console.ReadLine());

                                            bool checkTurkish = dictionaryTurkish.ContainsKey(turkish);
                                            if (checkTurkish)
                                            {
                                                Console.WriteLine("The desired value ({0} ---> {1}) is already in the dictionary.", turkish, dictionaryTurkish[turkish]);
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            else
                                            {
                                                Console.Write("Please enter English word: ");
                                                english = ToTitleCase(Console.ReadLine());
                                                dictionaryTurkish.Add(turkish, english);
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Please enter the Turkish word which you want to remove:");
                                            turkish = Console.ReadLine();
                                            dictionaryTurkish.Remove(turkish);
                                            if (dictionaryTurkish.Remove(turkish) == true)
                                                Console.WriteLine("Data is removed!");
                                            else
                                                Console.WriteLine("Removing process is failed! ");
                                            break;
                                        case 4:
                                            foreach (KeyValuePair<string, string> data in dictionaryTurkish)
                                            {
                                                Console.WriteLine("|Turkish: {0} ---> English: {1}|\n-----------------------------------------------", data.Key, data.Value);
                                            }
                                            Console.WriteLine("Press any key to continue..:");
                                            Console.ReadKey();
                                            break;
                                        case 5:
                                            Console.WriteLine("Welcome to Check yourself part :)" +
                                                "\nLet me explain you some rules..:" +
                                                "\n1. There will be 10 words you should translate." +
                                                "\n2. Each correct answer is 10 points." +
                                                "\n3. Each wrong answer will take your 5 points." +
                                                "\n4. You have to answer all of them and empty answers will be considered wrong!" +
                                                "\nLet's start... Good luck :)");
                                            string randKey;
                                            string answer;
                                            int point = 0;
                                            for (int i = 0; i < 10; i++)
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Your Score: " + point);
                                                randKey = randomKey(dictionaryTurkish);
                                                Console.Write(randKey + "----> ");
                                                answer = ToTitleCase(Console.ReadLine());
                                                if (dictionaryTurkish[randKey] == answer)
                                                {
                                                    point += 10;
                                                    Console.WriteLine("Correct answer you've got 10 points :)" +
                                                        "\nWait 1 second!!!");
                                                    System.Threading.Thread.Sleep(1000);
                                                }
                                                else
                                                {
                                                    point -= 5;
                                                    Console.WriteLine("Wrong answer you've lost 5 points :)" +
                                                        "\nWait 1 second!!!");
                                                    System.Threading.Thread.Sleep(1000);
                                                }
                                            }
                                            Console.WriteLine("Your Final Score is: " + point);
                                            Console.WriteLine("Press any key to upper menu");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            if (operation != 6)
                                            {
                                                Console.WriteLine("Invalid Operation!");
                                                Console.Write("Try again..!");
                                                System.Threading.Thread.Sleep(1500);
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
                            } while (operation != 6);
                            break;
                        #endregion

                        #region English to Turkish Switch Case
                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------\n| 1. Search word            |");
                                Console.WriteLine("-----------------------------\n| 2. Add word               |");
                                Console.WriteLine("-----------------------------\n| 3. Remove word            |");
                                Console.WriteLine("-----------------------------\n| 4. List of all data       |");
                                Console.WriteLine("-----------------------------\n| 5. Check yourself (Test)  |");
                                Console.WriteLine("-----------------------------\n| 6. Home Page              |\n-----------------------------");
                                if (byte.TryParse(Console.ReadLine(), out operation))
                                {
                                    switch (operation)
                                    {
                                        case 1:
                                            Console.Write("Please enter the English word: ");
                                            english = ToTitleCase(Console.ReadLine());
                                            try
                                            {
                                                Console.WriteLine("|English: {0} ---> Turkish: {1}|\nPress any key to continue..", english, dictionaryEnglish[english]);
                                                Console.ReadKey();
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Not Found!");
                                            }
                                            break;
                                        case 2:
                                            Console.Write("Please enter English word: ");
                                            english = ToTitleCase(Console.ReadLine());

                                            bool checkEnglish = dictionaryEnglish.ContainsKey(english);
                                            if (checkEnglish)
                                            {
                                                Console.WriteLine("The desired value ({0} ---> {1}) is already in the dictionary.", english, dictionaryEnglish[english]);
                                                System.Threading.Thread.Sleep(2000);
                                            }
                                            else
                                            {
                                                Console.Write("Please enter Turkish word: ");
                                                turkish = ToTitleCase(Console.ReadLine());
                                                dictionaryTurkish.Add(english, turkish);
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("Please enter the English word which you want to remove:");
                                            english = Console.ReadLine();
                                            dictionaryEnglish.Remove(english);
                                            if (dictionaryEnglish.Remove(english) == true)
                                                Console.WriteLine("Data is removed!");
                                            else
                                                Console.WriteLine("Removing process is failed! ");
                                            break;
                                        case 4:
                                            foreach (KeyValuePair<string, string> data in dictionaryEnglish)
                                            {
                                                Console.WriteLine("|English: {0} ---> Turkish: {1}|\n-----------------------------------------------", data.Key, data.Value);
                                            }
                                            Console.WriteLine("Press any key to continue..:");
                                            Console.ReadKey();
                                            break;
                                        case 5:
                                            Console.WriteLine("Welcome to Check yourself part :)" +
                                                "\nLet me explain you some rules..:" +
                                                "\n1. There will be 10 words you should translate." +
                                                "\n2. Each correct answer is 10 points." +
                                                "\n3. Each wrong answer will take your 5 points." +
                                                "\n4. You have to answer all of them and empty answers will be considered wrong!" +
                                                "\nLet's start... Good luck :)");
                                            string randKey;
                                            string answer;
                                            int point = 0;
                                            for (int i = 0; i < 10; i++)
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Your Score: " + point);
                                                randKey = randomKey(dictionaryEnglish);
                                                Console.Write(randKey + "----> ");
                                                answer = ToTitleCase(Console.ReadLine());
                                                if (dictionaryEnglish[randKey] == answer)
                                                {
                                                    point += 10;
                                                    Console.WriteLine("Correct answer you've got 10 points :)" +
                                                        "\nWait 1 second!!!");
                                                    System.Threading.Thread.Sleep(1000);
                                                }
                                                else
                                                {
                                                    point -= 5;
                                                    Console.WriteLine("Wrong answer you've lost 5 points :)" +
                                                        "\nWait 1 second!!!");
                                                    System.Threading.Thread.Sleep(1000);
                                                }
                                            }
                                            Console.WriteLine("Your Final Score is: " + point);
                                            Console.WriteLine("Press any key to upper menu");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            if (operation != 6)
                                            {
                                                Console.WriteLine("Invalid Operation!");
                                                Console.Write("Try again..!");
                                                System.Threading.Thread.Sleep(1000);
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
                            } while (operation != 6);
                            break;
                        #endregion

                        default:
                            if (operation != 3)
                            {
                                Console.WriteLine("Invalid Operation!");
                                Console.Write("Try again..!");
                                System.Threading.Thread.Sleep(1500);
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

            } while (operation != 3);
        }
        static string ToTitleCase(string Text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);
        }
        static string randomKey (Dictionary<string,string> data)
        {
            List<string> keyList = new List<string>(data.Keys);
            Random rand = new Random();
            string randomKey = keyList[rand.Next(keyList.Count)];
            return randomKey;
        }
    }
}
