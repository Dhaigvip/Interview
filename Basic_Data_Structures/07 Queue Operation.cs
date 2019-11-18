using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Basic_Data_Structures
{
    public struct Applicant
    {
        public string name;
        public string sex;
        public void GetName(string n)
        {
            name = n;
        }
        public override string ToString()
        {
            return name;
        }
    }
    public class ApplicationProcessor
    {
        public void Start()
        {
            Queue males = new Queue();
            Queue females = new Queue();
            formLines(males, females);

            StartProcessing(males, females);

            if (males.Count > 0 || females.Count > 0)
                HeadOfLine(males, females);
            NewApplication(males, females);

            if (males.Count > 0 || females.Count > 0)
                HeadOfLine(males, females);
            NewApplication(males, females);

            Console.Write("press enter");
            Console.Read();
        }
        static void formLines(Queue male, Queue female)
        {

            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream($"Basic_Data_Structures.Applicants.dat"))
            using (StreamReader f = new StreamReader(stream))
            {
                while (f.Peek() != -1)
                {
                    Applicant d = new Applicant();
                    var line = f.ReadLine();
                    d.sex = line.Substring(0, 1);
                    d.name = line.Substring(2, line.Length - 2);
                    if (d.sex == "M")
                        male.Enqueue(d);
                    else
                        female.Enqueue(d);
                }
            }
        }
        void NewApplication(Queue male, Queue female)
        {
            Applicant m, w;
            m = new Applicant();
            w = new Applicant();
            if (male.Count > 0 && female.Count > 0)
            {
                m.GetName(male.Dequeue().ToString());
                w.GetName(female.Dequeue().ToString());
            }
            else if ((male.Count > 0) && (female.Count == 0))
                Console.WriteLine("Waiting on a female applicant.");
            else if ((female.Count > 0) && (male.Count == 0))
                Console.WriteLine("Waiting on a male applicant.");
        }
        void HeadOfLine(Queue male, Queue female)
        {
            Applicant w, m;
            m = new Applicant();
            w = new Applicant();
            if (male.Count > 0)
                m.GetName(male.Peek().ToString());
            if (female.Count > 0)
                w.GetName(female.Peek().ToString());
            if (m.name != "" && w.name != "")
                Console.WriteLine("Next in line are: " + m.name + "\t" + w.name);
            else if (m.name != "")
                Console.WriteLine("Next in line is: " + m.name);
            else
                Console.WriteLine("Next in line is: " + w.name);
        }
        void StartProcessing(Queue male, Queue female)
        {
            Applicant m, w;
            m = new Applicant();
            w = new Applicant();
            Console.WriteLine("Application partners are: ");
            Console.WriteLine();
            for (int count = 0; count <= 3; count++)
            {
                m.GetName(male.Dequeue().ToString());
                w.GetName(female.Dequeue().ToString());
                Console.WriteLine(w.name + "\t" + m.name);
            }
        }
    }
}
