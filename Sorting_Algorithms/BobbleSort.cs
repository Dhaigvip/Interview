using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class BobbleSort : ISort
    {
        /*
        1. The sort gets its name because values “float like a bubble” from one end of
           the list to another. 
        2. Outer loop starts at the end of the array and moves toward the beginning of the array
        3. The inner loop starts at the first element of the array and ends when it
           gets to the next to last position in the array   
        4. The inner loop compares the two adjacent positions indicated by inner and inner +1, swapping them if
           necessary.
             
             
        */
        public int[] Sort(int[] array)
        {
            int temp;
            int upper = array.Length;

            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if ((int)array[inner] > array[inner + 1])
                    {
                        temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
