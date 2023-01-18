using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyProblemExample
{
    public class Sorter
    {
        public void Sort(double[] list)
        {
            int size = list.Length;
            if(size<100) // use bubble sort
            {
                Console.WriteLine("Using Bubble Sort");
                double temp;
                int counter, index;
                int length = list.Length;
                for (counter = 0; counter< length -1 ; counter++)
                {
                    for (index = 0; index < length -1 - counter; index++)
                    {
                        if(list[index] > list[index+1])
                        {
                            temp = list[index];
                            list[index] = list[index + 1];
                            list[index + 1] = temp;
                        }
                    }
                }
            }
            else if(size < 100000) // use quick sort
            {
                Console.WriteLine("Using Quick Sort");
                QuickSort(list, 0, list.Length - 1);
            }
            else // use Arrays to sort
            {
                Console.WriteLine("Using C# Sort");
                Array.Sort(list);
            }
        }

        private void QuickSort(double[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
        }
    }
}
