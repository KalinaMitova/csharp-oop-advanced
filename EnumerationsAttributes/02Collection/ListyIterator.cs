using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _02Collection
{

        public class ListyIterator<T> : IEnumerable<T>
    {
            private IList<T> myCollection;
            public int currentIndex { get; private set; }

            public ListyIterator(IList<T> myCollection)
            {
                this.myCollection = myCollection;
            this.currentIndex = 0;
           }

        public bool Move()
        {
            if (++this.currentIndex < this.myCollection.Count)
            {
                return true;
            }

            this.currentIndex--;
            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.myCollection.Count - 1)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            if (this.myCollection.Count == 0)
            {
                throw new OperationCanceledException("Invalid Operation!");             
            }
                return myCollection[currentIndex].ToString();
        }

        public string PrintAll()
        {
            if (this.myCollection.Count == 0)
            {
                throw new OperationCanceledException("Invalid Operation!");
            }
            StringBuilder printCollection = new StringBuilder();
            foreach (var item in this.myCollection)
            {
                    printCollection.Append(item.ToString() +" ");
            }
            
            return printCollection.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.myCollection.Count; i++)
            {
                yield return this.myCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
