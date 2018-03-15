
namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    public class MyList : AddRemoveCollection
    {
        public MyList()
            : base()
        {

        }

        public int Used
        {
            get { return base.MyCollection.Count; }
        }

        public override List<string> Remove(int count)
        {
            List<string> removedString = new List<string>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    removedString.Add(base.MyCollection[0]);
                    base.MyCollection.RemoveAt(0);
                }
                catch {}                
            }
            return removedString;
        }
    }
}
