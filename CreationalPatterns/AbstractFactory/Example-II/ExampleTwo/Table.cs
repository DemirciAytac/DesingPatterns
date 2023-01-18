using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    public class Table : IComponent
    {
        public void Paint()
        {
            Console.WriteLine("Table paint");
        }
    }
}
