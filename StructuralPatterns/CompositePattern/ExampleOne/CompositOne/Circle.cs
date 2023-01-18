using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public class Circle : GraphicObject
    {
        public Circle(string name, string color) : base(name, color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing an Circle: {Name}");
        }

        public override void Erase()
        {
            Console.WriteLine($"Erase an Circle: {Name}");
        }

        public override void Paint()
        {
            Console.WriteLine($"Paint an Circle: {Name}");
        }
    }
}
