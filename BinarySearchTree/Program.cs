using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
        public int FindMin()
        {
            Node current = root;
            while (!(current.Left == null))
            {
                current = current.Left;
            }
            return current.Data;
        }
        public int FindMax()
        {
            Node current = root;
            while (!(current.Right == null))
            {
                current = current.Right;
            }
            return current.Data;
        }

        /*
         *  An inorder traversal visits all the nodes in a BST in ascending order
            of the node key values. A preorder traversal visits the root node first, followed
            by the nodes in the subtrees under the left child of the root, followed by the
            nodes in the subtrees under the right child of the root.
         */
        public void InOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }
        public void PreOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }
        public void PostOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }
        public Node Find(int key)
        {
            Node current = root;
            while (current.Data != key)
            {
                if (key < current.Data)
                    current = current.Left;
                else
                {
                    current = current.Right;
                    if (current == null)
                        return null;
                }
            }
            return current;
        }

        public Node Delete(int key)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;

            while (current.Data != key)
            {
                parent = current;
                if (key < current.Data)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            if ((current.Left == null) & (current.Right == null))
            {
                if (current == root)
                    root = null;
                else if (isLeftChild)
                    parent.Left = null;
                else
                    parent.Right = null;
            }
        }
    }
}
