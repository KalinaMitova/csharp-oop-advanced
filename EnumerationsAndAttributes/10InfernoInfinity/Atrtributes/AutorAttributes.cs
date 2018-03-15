namespace _10InfernoInfinity.Atrtributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Class)]
    public class AutorAttribute : Attribute
    {
        public string author;
        public int revision;
        public string description;
        public List<string> reviewers;

        public AutorAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.author = author;
            this.revision = revision;
            this.description = description;
            this.reviewers = new List<string>();

            for (int i = 0; i < reviewers.Count(); i++)
            {
                this.reviewers.Add(reviewers[i]);
            }
        }
    }
}
