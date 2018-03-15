using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LinkedListTraversal
{
    public class LinkedList<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int Count { get; private set; }

        public LinkedList()
        {
            this.Count = 0;
        }

        public void Add(T element)
        {
            if (this.Count == 0)
            {
                this.tail = new Node<T>(element);
            }
            else if(this.Count == 1)
            {
                this.head = new Node<T>(element);
                this.head.Previous = this.tail;
                this.tail.Next = this.head;
            }
            else
            {
                Node<T> current = new Node<T>(element);
                current.Previous = this.head;
                this.head.Next = current;
                this.head = current;
            }
            this.Count++;
        }

        public void Remove(T element)   
        {
            Node<T> current = tail;
            while (current != null)
            {
                if (current.Value.Equals(element))
                {
                    if (current == this.tail)
                    {
                        current.Next.Previous = null;
                        this.tail = current.Next;
                    }
                    else if (current == this.head)
                    {
                        current.Previous.Next = null;
                        this.head = current.Previous;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    
                    current.Next = null;
                    current.Previous = null;
                    current = null;
                    this.Count--;
                    break;
                }
            current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

    }
}
