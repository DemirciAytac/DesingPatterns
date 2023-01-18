using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample
{
    public class QuickSort : ISorter
    {
        public void Sort(double[] list)
        {
            Console.WriteLine("Using Quick Sort");
            int leftIndex = 0, rightIndex = list.Length - 1;
            var i = leftIndex;
            var j = rightIndex;
            var pivot = list[leftIndex];
            while (i <= j)
            {
                while (list[i] < pivot)
                {
                    i++;
                }

                while (list[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    double temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

        }
    }
}
