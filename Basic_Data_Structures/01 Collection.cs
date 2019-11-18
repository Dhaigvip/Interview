using System;
using System.Collections;

namespace Basic_Data_Structures
{
    /// <summary>
    /// This is my custom collection. 
    /// The methods we will implement in this first section are the 
    /// Add, Remove, Count, and Clear methods.
    /// </summary>
    public class MyCollection : CollectionBase
    {

        /*
         * ArrayLists store data as objects (the Object data type), which is why we
            have declared item as Object.
         */

        public void Add(Object item)
        {
            InnerList.Add(item);
        }
        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
        /*
         We have to use the new keyword to hide the definition of Count found in CollectionBase.
        */

        public new int Count()
        {
            return InnerList.Count;
        }
    }
}
