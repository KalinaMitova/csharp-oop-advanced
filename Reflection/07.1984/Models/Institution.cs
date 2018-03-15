namespace _07._1984.Models
{
    using EventsArgs;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Institution : Entity
    {
        private List<string> monitoredObject;
        private StringBuilder output { get; }
        private int count;

        public Institution(string id, string name, params string[] monitoredObject) 
            : base(id, name)
        {
            this.MonitoredObject = new List<string>();
            foreach (var item in monitoredObject)
            {
                this.MonitoredObject.Add(item);
                this.output = new StringBuilder();
            }
        }

        public List<string> MonitoredObject
        {
            get { return this.monitoredObject; }

            set { this.monitoredObject = value; }
        }

        public void ChangeNameAction (object sender, StateChangeEventArgs args)
        {
            if (this.monitoredObject.Contains(args.PropertyName))
            {
                this.count++;
                output.AppendLine($"--{args.TypeName}(ID:{args.Id}) changed {args.PropertyName}({args.PropertyType}) from {args.OldName} to {args.NewName}");
            }
        }

        public override string ToString()
        {
            return $"{base.Name}: {this.count} changes registered{Environment.NewLine}" + this.output.ToString();     
        }
    }
}
