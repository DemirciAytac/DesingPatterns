using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample.SorterFactories
{
    public class SorterFactory : ISorterFactory
    {
        public ISorter CreateBubbleSort()
        {
            return new BubbleSort();
        }

        public ISorter CreateDefaultSort()
        {
            return new DefaultSorter();
        }

        public ISorter CreateQuickSort()
        {
            return new QuickSort();
        }
    }
}
