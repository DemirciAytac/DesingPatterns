using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class TableFactory : IGuiFactory
    {
        public IComponent Create()
        {
            return new Table();
        }
    }
}
