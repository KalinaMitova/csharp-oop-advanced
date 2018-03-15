
namespace _06.BirthdayCelebrations
{
    using Interfaces;

    public class Citizen : IIDable, IBirthdatable, INamable
    {
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.age = age;
            this.ID = id;
            this.Birthdate = birthdate;  
        }

        public string ID {get;}

        public string Birthdate { get; private set; }

        public string Name { get; private set; }
    }
}
