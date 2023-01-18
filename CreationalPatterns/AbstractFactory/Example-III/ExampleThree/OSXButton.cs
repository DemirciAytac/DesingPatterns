using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleThree
{
    public class OSXButton : Button
    {
        public override void Paint()
        {
            Console.WriteLine("Painting OSX Button");
        }
    }
}
