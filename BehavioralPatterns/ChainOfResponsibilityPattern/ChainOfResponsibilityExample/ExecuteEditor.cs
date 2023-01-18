using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class ExecuteEditor : IEditor
    {
        public IEditor Successor { get; private set; }

        public ExecuteEditor(IEditor successor)
        {
            Successor = successor;
        }

        public void ReviewDocument(string text)
        {
            if(text.Length<20)
            {
                Console.WriteLine($"Document ExecuteEditor tarafından onaylandı");
            }
            else
            {
                Successor.ReviewDocument(text);
            }
        }
    }
}
