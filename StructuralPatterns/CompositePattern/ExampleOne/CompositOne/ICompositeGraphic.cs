using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositOne
{
    public interface ICompositeGraphic
    {
        void AddGraphic(IGraphic graphic);
        void RemoveGraphic(IGraphic graphic);
        List<IGraphic> GetGraphic();
        void ListGraphic();
    }
}
