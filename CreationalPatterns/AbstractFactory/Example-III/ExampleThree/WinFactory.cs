using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleThree
{
    public class WinFactory : IGUIFactory
    {
        public IComponent CreateButton()
        {
            return new WinButton();
        }

        public IComponent CreateList()
        {
            return new WinList();
        }

        public IComponent CreateTable()
        {
            return new WinTable();
        }
    }
}
