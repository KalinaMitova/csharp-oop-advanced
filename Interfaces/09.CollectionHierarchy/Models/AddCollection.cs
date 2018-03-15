
namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;

    public class AddCollection : Collection
    {
        public AddCollection()
            : base()
        {       
        }

        public override List<int> Add(params string[] words)
        {
            List<int> addListResult = new List<int>();
            int index = 0;

            foreach (var word in words)
            {
                base.MyCollection.Add(word);
                addListResult.Add(index);
                index++;
            }
            return addListResult;  
        }
    }
}
