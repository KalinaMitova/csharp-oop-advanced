namespace _06MirrorImageLast.Models
{
    using System;
    using Contracts;

    public abstract class Wizard : IWizard
    {
        public  int id;
        private string name;
        private int magicPower;

        protected Wizard(string name, int magicPower)
        {
            this.Name = name;
            this.MagicPower = magicPower;
        }
        protected Wizard(string name, int magicPower, int id)
            :this(name, magicPower)
        {
            this.Id = id;
        }

        public int Id
        {
            get { return this.id; }

            protected set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                this.name = value;
            }
        }

        public int MagicPower
        {
            get { return this.magicPower; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Magic power must be greater than zero!");
                }
                this.magicPower = value;
            }
        }

        public override bool Equals (object obj)
        {
            return this.Id.Equals(obj);
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
