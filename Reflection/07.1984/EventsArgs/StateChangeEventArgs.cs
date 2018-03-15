namespace _07._1984.EventsArgs
{
    using System;

    public class StateChangeEventArgs : EventArgs
    {
        public StateChangeEventArgs(string typeName, string id, string propertyName, string propertyType,string oldName, string newName)
        {
            this.TypeName = typeName;
            this.Id = id;
            this.PropertyName = propertyName;
            this.PropertyType = propertyType;
            this.OldName = oldName;
            this.NewName = newName;
        }

        public string TypeName;
        public string PropertyName;
        public string PropertyType;
        public string Id { get; private set; }
        public string OldName { get; private set; }
        public string NewName { get; private set; }
    }
}
