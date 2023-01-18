using StrategySolutionExample.SorterFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample
{
    public class SortingContext
    {
        ISorterFactory factory = new SorterFactory();
        public void SortDouble(double[] list)
        {
            int size = list.Length;
            if(size < 100)
            {
                factory.CreateBubbleSort().Sort(list);
            }

            else if(size < 10000)
            {
                factory.CreateQuickSort().Sort(list);
            }
            else
            {
                factory.CreateDefaultSort().Sort(list);
            }
        }
    }
}
