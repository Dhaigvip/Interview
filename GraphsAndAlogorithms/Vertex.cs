using System;
using System.Collections.Generic;
using System.Text;

namespace GraphsAndAlogorithms
{
    public class Vertex
    {
        public bool wasVisited;
        public string label;
        public Vertex(string label)
        {
            this.label = label;
            wasVisited = false;
        }
    }
}
