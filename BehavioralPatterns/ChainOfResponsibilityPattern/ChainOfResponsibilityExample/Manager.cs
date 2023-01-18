using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class Manager : IEditor
    {
        public IEditor Successor { get; private set; }
        public void ReviewDocument(string text)
        {
            Console.WriteLine($"Document Manager tarafından onaylandı");
        }
    }
}
