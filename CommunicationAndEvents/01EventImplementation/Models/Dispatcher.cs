namespace _01EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get { return this.name; }

            set
            {
                OnNameChange(new NameChangeEventArgs(value));
                this.name = value;
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChange != null)
            {
                NameChange(this, args);
            }
        }
    }
}
