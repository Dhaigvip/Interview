using System;
using System.Collections;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Frequently used string methods
            string string1 = "Hello, world!";
            int len = string1.Length;
            // IndexOf
            int pos = string1.IndexOf(" ");

            string firstWord, secondWord;

            //SubString
            firstWord = string1.Substring(0, pos);
            secondWord = string1.Substring(pos + 1,
            (len - 1) - (pos + 1));
            Console.WriteLine("First word: " + firstWord);
            Console.WriteLine("Second word: " + secondWord);

            string[] nouns = new string[] { "cat", "dog", "bird", "eggs", "bones" };
            ArrayList pluralNouns = new ArrayList();
            foreach (string noun in nouns)
            {
                if (noun.EndsWith("s"))
                    pluralNouns.Add(noun);
            }

            foreach (string noun in pluralNouns)
            {
                Console.Write(noun + " ");
            }


            #endregion


            #region Split String
            //Split string
            string astring = "now is the time for all good people ";
            ArrayList words = new ArrayList();
            words = SplitWords(astring);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            #endregion

            #region String comparision
            string s1 = "foobar";
            string s2 = "foobar";
            int compVal = String.Compare(s1, s2);
            switch (compVal)
            {
                case 0:
                    Console.WriteLine(s1 + " " + s2 + " are equal");
                    break;
                case 1:
                    Console.WriteLine(s1 + " is less than " + s2);
                    break;
                case 2:
                    Console.WriteLine(s1 + " is greater than            " + s2);
                    break;
                default:
                    Console.WriteLine("Can't compare");
                    break;
            }
            #endregion

            #region string manipulation
            string s3 = "Hello, . Welcome to my class.";
            string name = "Clayton";
            int pos1 = s3.IndexOf(",");
            s3 = s3.Insert(pos1 + 2, name);
            Console.WriteLine(s3);
            #endregion

            #region Padding
            string[,] names = new string[,]{
                                {"1504", "Mary", "Ella", "Steve", "Bob"},
                                {"1133", "Elizabeth", "Alex", "David", "Joe"},
                                {"2624", "Joel", "Chris", "Craig", "Bill"}
                                };
            Console.WriteLine();
            Console.WriteLine();
            for (int outer = 0; outer <= names.GetUpperBound(0); outer++)
            {
                for (int inner = 0; inner <= names.GetUpperBound(1); inner++)
                {
                    Console.Write(names[outer, inner] + " ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int outer = 0; outer <= names.GetUpperBound(0); outer++)
            {
                for (int inner = 0; inner <= names.GetUpperBound(1); inner++)
                {
                    Console.Write(names[outer, inner].PadRight(10) + " ");
                    Console.WriteLine();
                }
            }

            #endregion

            #region StringToStringBuilderComparision
            var compare = new StringBuilderTest();
            compare.CompareStringToStringBuilder();

            #endregion

            Console.Read();
        }
        static ArrayList SplitWords(string astring)
        {
            string[] ws = new string[astring.Length - 1];
            ArrayList words = new ArrayList();
            int pos;
            string word;
            pos = astring.IndexOf(" ");
            while (pos >= 0)
            {
                word = astring.Substring(0, pos);
                words.Add(word);
                astring = astring.Substring(pos + 1,
                astring.Length - (pos + 1));
                if (pos == -1)
                {
                    word = astring.Substring(0, astring.Length);
                    words.Add(word);
                }
            }
            return words;
        }
    }
}
