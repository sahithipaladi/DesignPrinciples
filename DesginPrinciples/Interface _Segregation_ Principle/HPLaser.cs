using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Interface_Segregation_Principle
{
    public class HPLaser : IPrintContent, IPrintDuplex
    {
        public void PrintContent()
        {
            Console.WriteLine("\nPrint Content Data of HPLaser");
        }
        public void PrintDuplexContent()
        {
            Console.WriteLine("\nPrint Duplex Content Data of HPLaser");
        }
    }
}

