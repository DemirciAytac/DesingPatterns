using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternProblem
{
    public class FileValidator
    {
        public bool IsValid(FileInfo file)
        {
            if (file.Extension != ".txt" && file.Extension != ".html")
                return false;
            else if (file.Extension == ".txt" && file.Length > 5 * 1024 * 1024)
                return false;
            else if (file.Extension == ".html" && file.Length > 10 * 1024 * 1024)
                return false;
            else if (file.FullName.Length > 150)
                return false;

            return true;
        }
    }
}
