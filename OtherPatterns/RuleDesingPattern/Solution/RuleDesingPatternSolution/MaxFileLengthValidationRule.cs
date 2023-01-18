using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public class MaxFileLengthValidationRule : IFileValidationRule
    {
        private long Length { get; set; }

        public MaxFileLengthValidationRule(long length) => Length = length;

        public bool IsValid(FileInfo info) => info.Length <= Length;
    }
}
