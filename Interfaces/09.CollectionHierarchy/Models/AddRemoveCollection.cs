
namespace _09.CollectionHierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddRemoveCollection : Collection, IRemovable
    {
        public AddRemoveCollection():
            base()
        {
        }

        public override List<int> Add(params string[] words)
        {
            List<int> addListResult = new List<int>();

            foreach (var word in words)
            {
                base.MyCollection.Add(word);
                addListResult.Add(0);
            }
            return addListResult;
        }

        public virtual List<string> Remove(int count)
        {
            List<string> removedString = new List<string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    int index = base.MyCollection.Count - 1;
                    removedString.Add(base.MyCollection[index]);
                    base.MyCollection.RemoveAt(index);
                }
                catch { }        
            }

            return removedString;
        }
    }
}
