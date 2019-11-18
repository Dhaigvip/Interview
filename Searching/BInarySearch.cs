using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    public class BinarySearch
    {
        int[] arr = null;
        public BinarySearch(int[] arr_In)
        {
            arr = arr_In;
        }
        public int BinarySearchByLoop(int value)
        {
            int upperBound, lowerBound;
            int mid = 0;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (arr[mid] == value)
                {
                    return mid;
                }
                else if (value < arr[mid])
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }
            }
            return -1;
        }

        public int BinarySearchRecursive(int value, int lower, int upper)
        {
            if (lower < upper)
            {
                int mid;
                mid = (int)(upper + lower) / 2;
                if (value < arr[mid])
                {
                    BinarySearchRecursive(value, lower, mid - 1);
                }
                else if (value == arr[mid])
                {
                    return mid;
                }
                else
                {
                    BinarySearchRecursive(value, mid + 1, upper);
                }
            }
            return -1;
        }
    }
}
