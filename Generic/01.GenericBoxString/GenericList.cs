
namespace _01.GenericBoxString
{
    using System.Collections.Generic;
    using System.Text;
    public class GenericList<T>
    {
        private IList<T> myList;

        public  GenericList()
            {
            this.myList = new List<T>();
            }

        public void Add (T item)
        {
            this.myList.Add(item);
        }

        public T this[int index]    
        {
            get { return this.myList[index]; }

            private set { this.myList[index] = value; }
        }

        public void SwapElement (int index1, int index2)
        {
            T holder = this.myList[index1];
            this.myList[index1] = this.myList[index2];
            this.myList[index2] = holder;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in this.myList)
            {
                output.AppendLine(item.ToString());
            }
            return output.ToString();
        }
    }
}
