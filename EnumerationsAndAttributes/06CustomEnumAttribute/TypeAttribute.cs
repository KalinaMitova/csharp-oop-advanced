using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CustomEnumAttribute
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class)]
    public class TypeAttribute : Attribute
    {
        public string Type { get; }
        public string Category { get; }
        public string Description { get; }

        public TypeAttribute (string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
