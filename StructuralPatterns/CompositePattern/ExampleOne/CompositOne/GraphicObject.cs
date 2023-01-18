using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public abstract class GraphicObject : IGraphic
    {
        public string Name { get; }
        public string Color { get; }
        public GraphicObject(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public abstract void Draw();


        public abstract void Erase();

        public abstract void Paint();

        public override string ToString()
        {
            return $"Graphic Object: {Name} Color: {Color}";
        }
    }
}
