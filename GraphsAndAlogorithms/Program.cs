using System;

namespace GraphsAndAlogorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DepthFirst-BreadthFirstSearch
            Graph aGraph = new Graph(13);
            aGraph.AddVertex("A");
            aGraph.AddVertex("B");
            aGraph.AddVertex("C");
            aGraph.AddVertex("D");
            aGraph.AddVertex("E");
            aGraph.AddVertex("F");
            aGraph.AddVertex("G");
            aGraph.AddVertex("H");
            aGraph.AddVertex("I");
            aGraph.AddVertex("J");
            aGraph.AddVertex("K");
            aGraph.AddVertex("L");
            aGraph.AddVertex("M");
            aGraph.AddEdge(0, 1);
            aGraph.AddEdge(1, 2);
            aGraph.AddEdge(2, 3);
            aGraph.AddEdge(0, 4);
            aGraph.AddEdge(4, 5);
            aGraph.AddEdge(5, 6);
            aGraph.AddEdge(0, 7);
            aGraph.AddEdge(7, 8);
            aGraph.AddEdge(8, 9);
            aGraph.AddEdge(0, 10);
            aGraph.AddEdge(10, 11);
            aGraph.AddEdge(11, 12);
            Console.WriteLine("Depth first search");
            Console.WriteLine("----------------------------------------------");
            aGraph.DepthFirstSearch();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Breadth first search");
            Console.WriteLine("----------------------------------------------");
            aGraph.BreadthFirstSearch();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            #endregion

            #region Minimum Spanning tree
            Graph sGraph = new Graph(7);
            sGraph.AddVertex("A");
            sGraph.AddVertex("B");
            sGraph.AddVertex("C");
            sGraph.AddVertex("D");
            sGraph.AddVertex("E");
            sGraph.AddVertex("F");
            sGraph.AddVertex("G");
            sGraph.AddEdge(0, 1);
            sGraph.AddEdge(0, 2);
            sGraph.AddEdge(0, 3);
            sGraph.AddEdge(1, 2);
            sGraph.AddEdge(1, 3);
            sGraph.AddEdge(1, 4);
            sGraph.AddEdge(2, 3);
            sGraph.AddEdge(2, 5);
            sGraph.AddEdge(3, 5);
            sGraph.AddEdge(3, 4);
            sGraph.AddEdge(3, 6);
            sGraph.AddEdge(4, 5);
            sGraph.AddEdge(4, 6);
            sGraph.AddEdge(5, 6);

            Console.WriteLine("Minimum spanning tree");
            Console.WriteLine("----------------------------------------------");
            sGraph.MinimumSpanningTree();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");


            #endregion

            Console.WriteLine();
        }
    }
}
