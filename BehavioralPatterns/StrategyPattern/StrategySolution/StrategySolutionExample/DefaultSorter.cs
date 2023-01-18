using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample
{
   public class DefaultSorter : ISorter
    {
        public void Sort(double[] list)
        {
            Console.WriteLine("Using C# Sort");
            Array.Sort(list);
        }
    }
}
