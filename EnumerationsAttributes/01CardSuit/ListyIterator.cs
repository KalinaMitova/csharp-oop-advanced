using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CardSuit
{

        public class ListyIterator<T> 
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
            if (this.myCollection.Count == 0 /*|| currentIndex >= this.myCollection.Count*/)
            {
                throw new OperationCanceledException("Invalid Operation!");             
            }
                return myCollection[currentIndex].ToString();
        }

    }
}
