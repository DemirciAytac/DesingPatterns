using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public class Canvas : GraphicObject, ICompositeGraphic
    {
        public List<IGraphic> elements;
        public Canvas(string name, string color):base(name,color)
        {
            elements = new List<IGraphic>();
        }
        public void AddGraphic(IGraphic graphic)
        {
            elements.Add(graphic);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawwing {Name} \n");
            foreach (var item in elements)
            {
                item.Draw();
            }
        }

        public override void Erase()
        {
            Console.WriteLine($"Erasing {Name} \n");
            foreach (var item in elements)
            {
                item.Erase();
            }
        }

        public List<IGraphic> GetGraphic()
        {
            return elements;
        }

        public void ListGraphic()
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        public override void Paint()
        {
            Console.WriteLine($"Painting {Name} \n");
            foreach (var item in elements)
            {
                item.Paint();
            }
        }

        public void RemoveGraphic(IGraphic graphic)
        {
            elements.Remove(graphic);
        }
    }
}
