using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleThree
{
    public class OSXFactory : IGUIFactory
    {
        public IComponent CreateButton()
        {
            return new OSXButton();
        }

        public IComponent CreateList()
        {
            return new OSXList();
        }

        public IComponent CreateTable()
        {
            return new OSXTable();
        }
    }
}
