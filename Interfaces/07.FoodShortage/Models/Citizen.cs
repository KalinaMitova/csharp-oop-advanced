
namespace _07.FoodShortage.Models
{
    using Interfaces;

    public class Citizen : IBuyer
    {
        private string id;

        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
