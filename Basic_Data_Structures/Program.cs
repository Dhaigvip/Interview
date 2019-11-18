using System;
using System.Collections;

namespace Basic_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Collections
            //Create instance on cutome collection class
            MyCollection _myCollection = new MyCollection();

            //Add data to collection.
            _myCollection.Add("Item One");
            _myCollection.Add("Item Two");
            _myCollection.Add("Item Three");




            //Iterate through the items in a collection.
            IEnumerator enumerator = _myCollection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                // We need to cast the data, as we store it as an object in collection.
                var data = (string)enumerator.Current;
                Console.WriteLine($"Data in collection {data}");
            }

            //Remove an item from a collection
            _myCollection.Remove("Item Two");

            #endregion

            #region Arrays
            //Define a single dimentional array of integers.
            int[] array = new int[10];

            //Initialise an array
            int[] array1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };




            #endregion

            #region Dictionary
            #endregion

            #region HashTable
            #endregion

            #region Stack
            #endregion

            #region Queue
            #endregion
        }
    }
}
