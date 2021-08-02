using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPrinciples.Liskov_Substitution_Principle
{
    public class AdminDataFile : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic
            string adminPath = @"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\AdminData.txt";
            string text = File.ReadAllText(adminPath);
            Console.WriteLine("\nData Successfully read from AdminData");
            Console.WriteLine(text);
        }

        public void WriteFile(string filePath)
        {
            //Write File Logic
            string adminWritePath = @"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\AdminData.txt";
            using (StreamWriter writer = new StreamWriter(adminWritePath))
            {
                writer.WriteLine("UserName: Admin");
                writer.WriteLine("Password: test@123");
            }
            Console.WriteLine($"File has been written");

        }
    }
}