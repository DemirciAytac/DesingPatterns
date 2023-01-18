using System;
using System.IO;

namespace RuleDesingPatternProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fo = new FileInfo("C://Users//obss//Desktop//TasarımKalıpları//DesingPatterns//OtherPatterns//RuleDesingPattern//RuleDesingReadMe.txt");

            FileValidator fv = new FileValidator();
            fv.IsValid(fo);
            Console.WriteLine("Hello World!");
        }
    }
}
