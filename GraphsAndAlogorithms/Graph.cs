using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GraphsAndAlogorithms
{
    public class Graph
    {
        private int NUM_VERTICES = 5;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        private Stack<int> gStack;
        private Queue<int> gQueue;
        int numVerts;

        public Graph(int noOfVertices)
        {
            NUM_VERTICES = noOfVertices;
            gStack = new Stack<int>();
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
            {
                for (int k = 0; k <= NUM_VERTICES - 1; k++)
                {
                    adjMatrix[j, k] = 0;
                }
            }
        }
        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }
        public void AddEdge(int start, int eend)
        {
            adjMatrix[start, eend] = 1;
            adjMatrix[eend, start] = 1;
        }
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + " ");
        }
        /// <summary>
        /// Method to determine if a vertex has no successors and a method for removing a vertex from a graph.
        /// A vertex with no successors will be found in the adjacency matrix on a row
        /// where all the columns are zeroes.
        /// If a row is found with all zeroes in the columns, then that row number is returned.If both loops complete
        ///and no row number is returned, then a −1 is returned
        /// </summary>
        /// <returns></returns>
        public int NoSuccessors()
        {
            bool isEdge;
            for (int row = 0; row <= NUM_VERTICES - 1; row++)
            {
                isEdge = false;
                for (int col = 0; col <= NUM_VERTICES - 1; col++)
                {
                    if (adjMatrix[row, col] > 0)
                    {
                        isEdge = true;
                        break;
                    }
                }
                if (!(isEdge))
                    return row;
            }
            return -1;

        }

        public void DelVertex(int vert)
        {
            if (vert != NUM_VERTICES - 1)
            {
                for (int j = vert; j <= NUM_VERTICES - 1; j++)
                {
                    vertices[j] = vertices[j + 1];
                }
                for (int row = vert; row <= NUM_VERTICES - 1; row++)
                {
                    MoveRow(row, NUM_VERTICES);
                }
                for (int col = vert; col <= NUM_VERTICES - 1; col++)
                {
                    MoveCol(col, NUM_VERTICES - 1);
                }
            }
        }
        private void MoveRow(int row, int length)
        {
            for (int col = 0; col <= length - 1; col++)
                adjMatrix[row, col] = adjMatrix[row + 1, col];
        }
        private void MoveCol(int col, int length)
        {
            for (int row = 0; row <= length - 1; row++)
                adjMatrix[row, col] = adjMatrix[row, col + 1];
        }

        private int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
            {
                if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                {
                    return j;
                }
            }
            return -1;
        }
        /*
         1. First, pick a starting point, which can be any vertex
         2. Visit the vertex, push it onto a stack, and mark it as visited.
         3. Then you go to the next vertex that is unvisited, push it on the stack, and mark it.
         4. This continues until you reach the last vertex. (1-3)
         5. Then you check to see if the top vertex has any unvisited adjacent vertices.
         6. If it doesn’t, then you pop it off the stack and check the next vertex.
         7. If you find one, you start visiting adjacent vertices until there are no more, check for
            more unvisited adjacent vertices, and continue the process.
         8. When you finally reach the last vertex on the stack and there are no more adjacent, unvisited
            vertices, you’ve performed a depth-first search.
         */
        public void DepthFirstSearch()
        {
            vertices[0].wasVisited = true;
            ShowVertex(0);
            gStack.Push(0);
            int v;
            while (gStack.Count > 0)
            {
                v = GetAdjUnvisitedVertex(gStack.Peek());
                if (v == -1)
                    gStack.Pop();
                else
                {
                    vertices[v].wasVisited = true;
                    ShowVertex(v);
                    gStack.Push(v);
                }
            }
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                vertices[j].wasVisited = false;
        }

        /*
         *  1. Find an unvisited vertex that is adjacent to the current vertex, mark it as
                 visited, and add to a queue.
            2. If an unvisited, adjacent vertex can’t be found, remove a vertex from the
                queue (as long as there is a vertex to remove), make it the current vertex,
                and start over.
            3. If the second step can’t be performed because the queue is empty, the
                algorithm is finished. 
         */
        public void BreadthFirstSearch()
        {
            Queue gQueue = new Queue();
            vertices[0].wasVisited = true;
            ShowVertex(0);
            gQueue.Enqueue(0);
            int vert1, vert2;
            while (gQueue.Count > 0)
            {
                vert1 = (int)gQueue.Dequeue();
                vert2 = GetAdjUnvisitedVertex(vert1);
                while (vert2 != -1)
                {
                    vertices[vert2].wasVisited = true;
                    ShowVertex(vert2);
                    gQueue.Enqueue(vert2);
                    vert2 = GetAdjUnvisitedVertex(vert1);
                }
            }
            for (int i = 0; i <= NUM_VERTICES - 1; i++)
            {
                vertices[i].wasVisited = false;
            }
        }

        public void MinimumSpanningTree()
        {
            vertices[0].wasVisited = true;
            gStack.Clear();
            gStack.Push(0);
            int currVertex, ver;
            while (gStack.Count > 0)
            {
                currVertex = gStack.Peek();
                ver = GetAdjUnvisitedVertex(currVertex);
                if (ver == -1)
                    gStack.Pop();
                else
                {
                    vertices[ver].wasVisited = true;
                    gStack.Push(ver);
                    ShowVertex(currVertex);
                    ShowVertex(ver);
                    Console.Write(" ");
                }
            }
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                vertices[j].wasVisited = false;
        }
    }
}
