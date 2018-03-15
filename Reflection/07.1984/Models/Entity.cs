namespace _07._1984.Models
{
    using Contracts;
    using EventsArgs;

    public delegate void ChangeStateEventHandler(object sendler, StateChangeEventArgs args);

    public abstract class Entity : IEntity
    {
        private string name;
        private string id;

        protected Entity(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public event ChangeStateEventHandler ChangeName;

        public virtual string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Id { get; protected set; }

        protected void OnChangeState(StateChangeEventArgs args)
        {
            if (this.ChangeName != null)
            {
                ChangeName(this, args);
            }
        }
    }
}
