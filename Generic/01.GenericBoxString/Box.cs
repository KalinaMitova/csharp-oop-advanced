
namespace _01.GenericBoxString
{
    using System;

    public class Box<T>
    {
        private  T value;

        public  Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get
            {
                return this.value;
            }

            private set
            {
                this.value = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }

        public T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
                return second;
            else
                return first;
        }

    }

}
