using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    public class GuiFactory : IGuiFactory
    {
        public IComponent CreateButton()
        {
            return new Button();
        }

        public IComponent CreateList()
        {
            return new List();
        }

        public IComponent CreateTable()
        {
            return new Table();
        }
    }
}
