using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Basic_Data_Structures
{
    public struct pqItem
    {
        public int priority;
        public string name;
    }
    public class PriorityQueue : Queue
    {
        public PriorityQueue()
        {
        }
        public override object Dequeue()
        {
            object[] items;
            int min, minindex = 0;
            items = this.ToArray();
            min = ((pqItem)items[0]).priority;
            for (int x = 1; x <= items.Length; x++)
            {
                if (((pqItem)items[x]).priority < min)
                {
                    min = ((pqItem)items[x]).priority;
                    minindex = x;
                }
                this.Clear();
                for (int y = 0; y <= items.GetUpperBound(0); y++)
                {
                    if (y != minindex && ((pqItem)items[y]).name != "")
                        this.Enqueue(items[y]);
                }
            }
            return items[minindex];
        }
    }
}
