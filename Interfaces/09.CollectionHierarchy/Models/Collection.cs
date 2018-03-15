
namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public abstract class Collection : IAddable
    {
        private List<string> myCollection;

        public Collection ()
        {
            this.myCollection = new List<string>();
        }

        public List<string> MyCollection
        {
            get { return this.myCollection; }

            set { this.myCollection = value; }
        }

        public abstract List<int> Add(params string[] words);
    }
}
