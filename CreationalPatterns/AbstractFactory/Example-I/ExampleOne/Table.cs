using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class Table : IComponent
    {
        public void paint()
        {
            Console.WriteLine("Table paint");
        }
    }
}
