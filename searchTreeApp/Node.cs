using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchTreeApp
{
    public class Node<T> where T : IComparable
    {
        public T Value { get; set; }
        public Node<T> leftChild { get; set; }
        public Node<T> rightChild { get; set; }
    
        public Node(T value)
        {
            Value = value;
            leftChild = null;
            rightChild = null;
        }
    }
}
