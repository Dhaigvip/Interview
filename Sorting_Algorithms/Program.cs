using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 4, 8, 2, 7 };

            SelectionSort s = new SelectionSort();
            s.Sort(arr);
        }
    }
}
