using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class Editor : IEditor
    {
        public IEditor Successor { get; private set; }
        public Editor(IEditor successor)
        {
            Successor = successor;
        }
        public void ReviewDocument(string text)
        {
            if(text.Length < 10)
            {
                Console.WriteLine($"Document Editör tarafından onaylandı");
            }
            else
            {
                Successor.ReviewDocument(text);
            }
        }
    }
}
