
namespace _09.CollectionHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IAddable
    {
        List<int> Add(params string[] words);
    }
}
