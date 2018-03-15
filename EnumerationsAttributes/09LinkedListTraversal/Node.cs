using System;

namespace _09LinkedListTraversal
{
    public class Node<T>
        where T : IComparable<T>
    {
        public T Value { get;  set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }

    }
}
