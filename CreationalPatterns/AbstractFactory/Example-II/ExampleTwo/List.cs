using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    public class List : IComponent
    {
        public void Paint()
        {
            Console.WriteLine("List paint");
        }
    }
}
