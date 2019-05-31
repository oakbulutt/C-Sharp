using System;
using System.Collections;
using System.IO;

namespace BP12Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\oakbu\Desktop\Business Programming\File Exercise Text\Input.txt";
            string outputFilePath = @"C:\Users\oakbu\Desktop\Business Programming\File Exercise Text\Output.txt";
            ArrayList data = readDataFromFile(filePath);
           
            createFile(outputFilePath);
            writeDataToFile(outputFilePath, data);
        }
        #region Read Data From The File
        static ArrayList readDataFromFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            ArrayList data = new ArrayList();
            string read;
            char [] delimiterChars = { ' ' , '\t', '\n'};
            int i = 1;
            while ((read = sr.ReadLine()) != null)
            {
                string[] input = read.Split(delimiterChars);
                foreach (var item in input)
                {
                    string dataAdd = i + " " + item;
                    data.Add(dataAdd);
                    i++;
                }
            }
            sr.Close();
            return data;
        }
        #endregion

        #region Create File
        static void createFile(string filePath)
        {
            FileStream fs = File.Create(filePath);
            fs.Close();
        }
        #endregion

        #region Write Data Into The File
        static void writeDataToFile(string filePath, ArrayList data)
        {
            StreamWriter sw = new StreamWriter(filePath);
            foreach (var item in data)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
        #endregion
    }
}
