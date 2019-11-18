using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class SelectionSort : ISort
    {
        /*
       1. This sort works by starting at the beginning of the array, comparing the first element with the other elements
          in the array.
       2. The smallest element is placed in position 0, and the sort then begins again at position 1.
          This continues until each position except the last position has been the starting point for a new loop.
             
        */
        public int[] Sort(int[] array)
        {
            int min, temp;
            int upper = array.Length;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (array[inner] < array[min])
                    {
                        min = inner;
                        temp = array[outer];
                        array[outer] = array[min];
                        array[min] = temp;
                    }
                }
            }
            return array;
        }
    }
}
