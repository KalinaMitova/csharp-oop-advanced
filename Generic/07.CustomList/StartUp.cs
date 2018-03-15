
namespace _07.CustomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class CustomList<T> :IEnumerable
        where T : IComparable 
    {
        private List<T> myList;

        public CustomList()
        {
            this.myList =new  List<T>();
        }

        public List<T> MyList
        {
            get { return this.myList; }

            private set { this.myList = value; }
        }

        public T this[int index]
        {
            get { return this.myList[index]; }

            set { this.MyList[index] = value; }
        }

        public void Add(T element)      
        {
            this.MyList.Add(element);
        }

        public void Remove(int index)
        {
        this.MyList.RemoveAt(index);
        }

        public bool Contains(T element)
        {
            return this.MyList.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T holder = this.MyList[index1];
            this.MyList[index1] = this.MyList[index2];
            this.MyList[index2] = holder;
        }

        public int CountGreaterThan(T element)
        {
            int result = 0;
            foreach (var item in this.MyList)
            {
                if (item.CompareTo(element) > 0)
                {
                    result++;
                }
            }
            return result;
        }

        public T Min()
        {
            T min = this.MyList[0];
            foreach (var item in this.MyList)
            {
                if (min.CompareTo(item) >0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.MyList[0];
            foreach (var item in this.MyList)
            {
                if (max.CompareTo(item) <= 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public int Count()
        {
            int count = 0;

            foreach (var item in this.MyList)
            {
                count++;
            }

            return count;
        }

        public string PrintList()
        {
            StringBuilder output = new StringBuilder();
            foreach (var item in this.MyList)
            {
                output.AppendLine(item.ToString());
            }

            return output.ToString();
        }

        public IEnumerator GetEnumerator()
        {
           return this.MyList.GetEnumerator();
        }
    }

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            CustomList < string> list = new CustomList<string>();

            while (input != "END")
            {
                CommondInterpreter interpreter = new CommondInterpreter(input, list);
                interpreter.ParseCommand();
                input = Console.ReadLine();
            }
        }
    }
}
