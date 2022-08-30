using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace searchTreeApp
{
    public class Tree<T> where T : IComparable
    {
        public Node<T> root { get; set; }
        
        public void Insert(T value)
        {
            var node = new Node<T>(value);

            if (isEmpty())
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {
                if (value.CompareTo(current.Value) <0)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }

                    else current = current.leftChild;
                }

                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    else current = current.rightChild;
                }
            }
        }


        public bool Exists(T value)
        {
            var current = root;
            while (current != null)
            {
                if (value.CompareTo(current.Value) < 0) current = current.leftChild;
                else if (value.CompareTo(current.Value) > 0) current = current.rightChild;
                else return true;
            }
            return false;


        }

        public int Count()
        {
            return Count(root);
        }

        private int Count(Node<T> root)
        {
            if (root == null) return 0;

            else
            {
                return (1 + Count(root.leftChild) + Count(root.rightChild));
            }
        }
        
        //Per-Order Traversal
        public void traversePerOrder()
        {
            traversePerOrder(root);
        }

        private void traversePerOrder(Node<T> root)
        {
            if(root == null) return;
            Console.WriteLine(root.Value);
            traversePerOrder(root.leftChild);
            traversePerOrder(root.rightChild);
        }

        //In-Order Traversal
        public void traverseInOrder()
        {
            traverseInOrder(root);
        }

        private void traverseInOrder(Node<T> root)
        {
            if (root == null) return;
            traverseInOrder(root.leftChild);
            Console.WriteLine(root.Value);
            traverseInOrder(root.rightChild);
        }

        //Post-Order Traversal
        public void traversePostOrder()
        {
            traversePostOrder(root);
        }

        private void traversePostOrder(Node<T> root)
        {
            if (root == null) return;
            traversePostOrder(root.leftChild);
            traversePostOrder(root.rightChild);
            Console.WriteLine(root.Value);
        }

        public int Height()
        {
            return height(root);
        }
        private int height(Node<T> root)
        {
            if (root == null) return -1;
            if(root.leftChild == null && root.rightChild == null) return 0;
            return (1 + Math.Max(height(root.leftChild), height(root.rightChild)));
        }

        private bool isEmpty()
        {
            return root == null;
        }

       

        //public bool isBinarySearchTree()
        //{
        //    return isBinarySearchTree(root);
        //}

        //private bool isBinarySearchTree(Node<T> root, int min, int max)
        //{
        //    if (root == null) return true;
        //    if (root.Value.CompareTo(min) < 0 || root.Value.CompareTo(max) > 0) return false;
        //    return isBinarySearchTree(root.leftChild, min, root.Value -1) &&
        //        isBinarySearchTree(root.rightChild, root.Value + 1, max);
        //}


    }
}
