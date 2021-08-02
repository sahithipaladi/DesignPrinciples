using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Interface_Segregation_Principle
{
    public class Cannon : IPrintContent, IPhotoCopyContent
    {
        public void PrintContent()
        {
            Console.WriteLine("\nPrint Content Data of Cannon210");
        }
        public void PhotoCopyContent()
        {
            Console.WriteLine("\nPrint Copy Content Data of Cannon210");
        }
    }
}
