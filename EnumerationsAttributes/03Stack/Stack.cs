using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        IList<T> myStack;

        public Stack()
        {
            this.myStack = new List<T>();
        }

        public void Push(params T [] items )
        {
            foreach (var item in items)
            {
                myStack.Add(item);
            }
        }

        public void Pop()
        {
            if (this.Count() == 0)
            {
                throw new OperationCanceledException("No elements");
            }
            foreach (var item in this)
            {
                myStack.Remove(item);
                break;
            }
        }

        public string PrintStackTwice()
        {
            StringBuilder output = new StringBuilder();

            foreach (var item in this)
            {
                output.AppendLine(item.ToString());
            }

            output.Append(output.ToString());

            return output.ToString();

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = myStack.Count-1; i >= 0; i--)
            {
                yield return myStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
    }
}
