using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Basic_Data_Structures
{
    public class MyDictionary : DictionaryBase
    {
        public MyDictionary()
        {

        }

        public void Add(string name, string ip)
        {
            base.InnerHashtable.Add(name, ip);
        }
        public string Item(string name)
        {
            return base.InnerHashtable[name].ToString();
        }
        public void Remove(string name)
        {
            base.InnerHashtable.Remove(name);
        }

    }
}
