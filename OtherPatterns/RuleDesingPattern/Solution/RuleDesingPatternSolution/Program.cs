using System;
using System.IO;

namespace RuleDesingPatternSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            User PremiumAytac = new User("Aytac", UserStatus.Premium);
            User NormalVatandas = new User("Normal", UserStatus.Normal);
            FileInfo fo = new FileInfo("C://Users//obss//Desktop//TasarımKalıpları//DesingPatterns//OtherPatterns//RuleDesingPattern//RuleDesingReadMe.txt");

            FileValidator fv = new FileValidator(PremiumAytac);
            bool result = fv.IsValid(fo);
            Console.WriteLine("Hello World!");
        }
    }
}
