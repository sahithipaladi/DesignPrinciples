using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DesignPrinciples.Liskov_Substitution_Principle
{
    public class RegulaDataFile : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    

            string regularData = @"C:\Users\Admin\source\repos\DesignPrinciples\DesignPrinciples\Liskov Substitution Principle\RegularData.txt";
            string[] lines = File.ReadAllLines(regularData);
            Console.WriteLine("Data Successfully read from RegularData");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
