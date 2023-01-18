using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public interface IFileValidationRule
    {
        bool IsValid(FileInfo info);
    }
}
