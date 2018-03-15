
namespace _01_DefineInterfaceIPerson
{
    public class Citizen : IPerson
    {
        private int age;

        private string name;

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                this.name = value;
            }
        }

    }
}
