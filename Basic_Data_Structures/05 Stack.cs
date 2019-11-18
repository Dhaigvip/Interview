using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Basic_Data_Structures
{
    public class MyStack
    {
        private int _index;
        private ArrayList _list;
        public MyStack()
        {
            _list = new ArrayList();
            _index = -1;
        }
        public int count
        {
            get
            {
                return _list.Count;
            }
        }
        public void push(object item)
        {
            _list.Add(item);
            _index++;
        }
        public object pop()
        {
            object obj = _list[_index];
            _list.RemoveAt(_index);
            _index--;
            return obj;
        }
        public void clear()
        {
            _list.Clear();
            _index = -1;
        }
        public object peek()
        {
            return _list[_index];
        }
    }
}
