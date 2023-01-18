using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public class FileSizeForExtensionValidationRule : IFileValidationRule
    {
        private string Extension { get; set; }
        private long Bytes { get; set; }

        public FileSizeForExtensionValidationRule(string extension, long bytes)
        {
            Extension = extension;
            Bytes = bytes;
        }

        public bool IsValid(FileInfo info)
        {
            if (info.Extension != Extension) return true;
            return info.Length <= Bytes;
        }
    }
}
