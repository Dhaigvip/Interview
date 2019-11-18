using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Basic_Data_Structures
{
    public class MyHashTable
    {
        private Hashtable glossary = new Hashtable();
        public MyHashTable()
        {

        }
        public void ReadTextFile()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream($"Basic_Data_Structures.Dictionary.txt"))
            using (StreamReader f = new StreamReader(stream))
            {
                while (f.Peek() != -1)
                {
                    var line = f.ReadLine();
                    var words = line.Split('|');
                    glossary.Add(words[0], words[1]);
                }
            }
            PrintDictionary();
        }
        private void PrintDictionary()
        {
            var enumerator = glossary.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Key} - {enumerator.Value}");
            }
        }
    }
}
