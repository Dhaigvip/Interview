using System;

namespace LinkedList_Test
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Node
    {
        public Object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;
        }
        public Node(Object theElement)
        {
            Element = theElement;
            Link = null;
        }
    }
    public class DoubleNode
    {
        public Object Element;
        public DoubleNode Flink;
        public DoubleNode Blink;
        public DoubleNode()
        {
            Element = null; Flink = null;
            Blink = null;
        }
        public DoubleNode(Object theElement)
        {
            Element = theElement;
            Flink = null;
            Blink = null;
        }
    }
    class LinkedList
    {
        protected Node header;
        public LinkedList()
        {
            header = new Node("header");
        }
        private Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (current.header != item)
            {
                current = current.Link;
            }
            return current;
        }
        public void Insert(Object newItem, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }
        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && (current.Link.Element != n))
            {
                current = current.Link;
            }
            return current;
        }
        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Link == null))
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
    }
    class DoublyLinkedList
    {
        protected DoubleNode header;
        public DoublyLinkedList()
        {
            header = new DoubleNode("header");
        }
        private DoubleNode Find(Object item)
        {
            DoubleNode current = new DoubleNode();
            current = header;
            while (current.Element != item)
            {
                current = current.Flink;
            }
            return current;
        }
        public void Insert(Object newItem, Object after)
        {
            DoubleNode current = new DoubleNode();
            DoubleNode newNode = new DoubleNode(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }
        private DoubleNode FindLast()
        {
            DoubleNode current = new DoubleNode();
            current = header;
            while (!(current.Flink == null))
                current = current.Flink;
            return current;
        }
        public void Remove(Object n)
        {
            DoubleNode p = Find(n);
            if (!(p.Flink == null))
            {
                p.Blink.Flink = p.Flink;
                p.Flink.Blink = p.Blink;
                p.Flink = null;
                p.Blink = null;
            }
        }
        public void PrintReverse()
        {
            DoubleNode current = new DoubleNode();
            current = FindLast();
            while (!(current.Blink == null))
            {
                Console.WriteLine(current.Element);
                current = current.Blink;
            }
        }
        public void PrintList()
        {
            DoubleNode current = new DoubleNode();
            current = header;
            while (!(current.Flink == null))
            {
                Console.WriteLine(current.Flink.Element);
                current = current.Flink;
            }
        }
    }

    public class CircularLinkedList
    {
        protected DoubleNode current;
        protected DoubleNode header;
        private int count;
        public CircularLinkedList()
        {
            count = 0;
            header = new DoubleNode("header");
            header.Flink = header;
        }
        public bool IsEmpty()
        {
            return (header.Flink == null);
        }
        public void MakeEmpty()
        {
            header.Flink = null;
        }
        public void PrintList()
        {
            DoubleNode current = new DoubleNode();
            current = header;
            while (!(current.Flink.Element.ToString() == "header"))
            {
                Console.WriteLine(current.Flink.Element);
                current = current.Flink;
            }
        }
        private DoubleNode FindPrevious(Object n)
        {
            DoubleNode current = header;
            while (!(current.Blink == null) && current.Blink.Element != n)
            {
                current = current.Blink;
            }
            return current;
        }
        private DoubleNode Find(Object n)
        {
            DoubleNode current = new DoubleNode();
            current = header.Flink;
            while (current.Element != n)
            {
                current = current.Flink;
            }
            return current;
        }
        public void Remove(Object n)
        {
            DoubleNode p = FindPrevious(n);
            if (!(p.Flink == null))
            {
                p.Flink = p.Flink.Flink;
                count--;
            }
        }
        public void Insert(Object n1, Object n2)
        {
            DoubleNode current = new DoubleNode();
            DoubleNode newnode = new DoubleNode(n1);
            current = Find(n2);
            newnode.Flink = current.Flink;
            current.Flink = newnode;
            count++;
        }
        public void InsertFirst(Object n)
        {
            DoubleNode current = new DoubleNode(n);
            current.Blink = header;
            header.Flink = current;
            count++;
        }
        public DoubleNode Move(int n)
        {
            DoubleNode current = header.Flink;
            DoubleNode temp;
            for (int i = 0; i <= n; i++)
            {
                current = current.Flink;
            }
            if (current.Element.ToString() == "header")
            {
                current = current.Flink;

            }
            temp = current;
            return temp;
        }
    }


}
