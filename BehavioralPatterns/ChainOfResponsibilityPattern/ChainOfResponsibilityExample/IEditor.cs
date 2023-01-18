using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public interface IEditor
    {
        void ReviewDocument(string text);
    }
}
