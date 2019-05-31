using System;
using System.Collections;
using System.IO;

namespace BP12Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\oakbu\Desktop\Data.txt";
            ArrayList data = readDataFromFile(filePath);
            arithmeticMean(data);
            sum(data);
        }
        static void createFile(string filePath)
        {
            //FileStream fs = File.Create(@"C:\Users\oakbu\Desktop\Hello.txt");
            FileStream fs = File.Create(filePath);
            fs.Close();
            Console.WriteLine("File created!");
            Console.ReadKey();
        }
        static void isExist(string filePath)
        {
            //bool check = File.Exists(@"C:\Users\oakbu\Desktop\Hello.txt");
            bool check = File.Exists(filePath);
            if (check)
                Console.WriteLine("File is exist!");
            else
                Console.WriteLine("File is not exist!");
        }
        static void writeDataToFile(string filePath)
        {
            //StreamWriter sw = new StreamWriter(@"C: \Users\oakbu\Desktop\Hello.txt");
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("Hello world from writeDataToFile method!");
        }
        static ArrayList readDataFromFile(string filePath)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\oakbu\Desktop\Hello.txt");

            StreamReader sr = new StreamReader(filePath);
            ArrayList data = new ArrayList();
            string read;
            while((read = sr.ReadLine()) != null)
            {
                if (isNum(read) == true)
                    data.Add(Convert.ToDouble(read));
                else
                    break;
            }
            sr.Close();
            return data;
        }
        static void fileMove(string from, string to)
        {
            File.Move(from, to);
            //File.Move(@"C:\Users\oakbu\Desktop\Test.txt", @"C:\Users\oakbu\Desktop\Business Programming\Test.txt");
        }
        static void copyFile(string from, string to)
        {
            File.Move(from, to);
            //File.Copy(@"C:\Users\oakbu\Desktop\Hello.txt", @"C:\Users\oakbu\Desktop\Business Programming\Hello.txt");
        }
        static void deleteFile(string filePath)
        {
            File.Delete(filePath);
        }
        static void fileInfo(string filePath)
        {
            FileInfo fI = new FileInfo(filePath);

            string fileCreationTime = fI.CreationTime.ToString("dd.MM.yyyy hh:ss");
            string fileFullName = fI.FullName;
            DirectoryInfo dI = fI.Directory;
            FileInfo[] directoryInfoList = dI.GetFiles();
            string fileExtention = fI.Extension;
            long byteLength = fI.Length;
            string fileName = fI.Name;
            string directoryName = fI.DirectoryName;
        }
        static double arithmeticMean(ArrayList num)
        {
            double sum = 0;
            double arithmeticMean = 0;
            foreach (double value in num)
            {
                sum += value;
                arithmeticMean = sum / num.Count;
            }
            Console.WriteLine($"Arithmetic Mean: {arithmeticMean}");
            return arithmeticMean;
        }
        static double sum(ArrayList num)
        {
            double sum = 0;
            foreach (double value in num)
            {
                sum += value;
            }
            Console.WriteLine($"Sum: {sum}");
            return sum;
        }
        static bool isNum(string x)
        {
            try
            {
                Convert.ToDouble(x);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
