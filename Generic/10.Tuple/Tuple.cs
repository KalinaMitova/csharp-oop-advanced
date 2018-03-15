
namespace _10.Tuple
{
   public class Tuple<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public  Tuple (TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{this.key} -> {this.value}";
        }
    }
}
