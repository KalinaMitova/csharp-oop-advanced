

namespace _02MultipleImplementation
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private int age;

        private string name;

        private string birthday;

        private string id;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthday;
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

        public string Birthdate
        {
            get { return this.birthday; }

            private set
            {
                this.birthday = value;
            }
        }

        public string Id
        {
            get { return this.id; }

            private set
            {
                this.id = value;
            }
        }
    }
}
