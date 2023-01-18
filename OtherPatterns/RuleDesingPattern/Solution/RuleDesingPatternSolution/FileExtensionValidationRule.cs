using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public class FileExtensionValidationRule : IFileValidationRule
    {
        private string[] AllowedExtensions { get; set; }

        public FileExtensionValidationRule(string[] extensions) => AllowedExtensions = extensions;

        public bool IsValid(FileInfo info)
        {
            return AllowedExtensions.Contains(info.Extension);
        }
    }
}
