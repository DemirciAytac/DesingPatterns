using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public class Rectangle : GraphicObject
    {
        public Rectangle(string name, string color):base(name,color)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing an Rectangle: {Name}");
        }

        public override void Erase()
        {
            Console.WriteLine($"Erasing an Rectangle: {Name}");
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting an Rectangle: {Name}");
        }
    }
}
