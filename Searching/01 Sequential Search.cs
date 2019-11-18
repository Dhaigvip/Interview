using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    class Sequential_Search
    {
        int[] array;
        public Sequential_Search(int[] array_in)
        {
            array = array_in;
        }

        public int? SearchOptimised(int searchKey)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == searchKey && i > (array.Length * 0.2))
                {
                    swap(i, i - 1);
                    return i;
                }
                else
                {
                    if (array[i] == searchKey)
                        return i;
                }
            }
            return null;
        }
        void swap(int item1, int item2)
        {
            int temp = array[item1];
            array[item1] = array[item2];
            array[item2] = temp;
        }

        public int Search(int searchKey)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchKey)
                {
                    return i;
                }
            }
            return -1;
        }
        public int? FindMinimum(int[] array)
        {
            int? min = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public int? FindMaximum(int[] array)
        {
            int? max = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
