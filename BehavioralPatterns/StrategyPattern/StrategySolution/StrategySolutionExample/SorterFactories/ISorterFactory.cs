using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample.SorterFactories
{
    public interface  ISorterFactory
    {
        ISorter CreateBubbleSort();
        ISorter CreateQuickSort();
        ISorter CreateDefaultSort();
    }
}
