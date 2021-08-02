using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Liskov_Substitution_Principle
{
    public interface IFileReader
    {
        void ReadFile(string filePath);
    }
    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }
}