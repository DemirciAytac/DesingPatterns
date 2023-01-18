using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public  class Ellipse : GraphicObject
    {
        public Ellipse(string name, string color):base(name,color)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing an ellipse: {Name}");
        }

        public override void Erase()
        {
            Console.WriteLine($"Erasing an ellipse: {Name}");
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting an ellipse: {Name}");
        }
    }
}
