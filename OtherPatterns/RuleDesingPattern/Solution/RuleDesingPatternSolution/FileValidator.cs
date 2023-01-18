using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public class FileValidator
    {
        public User User { get; set; }

        public FileValidator(User user)
        {
            User = user;
        }

        public bool IsValid(FileInfo fileInfo)
        {
            var rules = new List<IFileValidationRule> { new FileExtensionValidationRule(new string[] { ".txt", ".html" }) };

            rules.Add(new FileSizeForExtensionValidationRule(".txt", 5 * 1024 * 1024));
            rules.Add(new FileSizeForExtensionValidationRule(".html", 10 * 1024 * 1024));

            if (User.Status != UserStatus.Premium)
            {
                rules.Add(new MaxFileLengthValidationRule(150));
            }

            bool isValid = rules.All(rule => rule.IsValid(fileInfo));
            return isValid;
        }
    }
}
