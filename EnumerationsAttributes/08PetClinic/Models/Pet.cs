using System;

namespace _08PetClinic
{
    public class Pet : IComparable<Pet>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Kind { get; private set; }

        public Pet()
        {
            this.Name = string.Empty; ;
            this.Age = 0;
            this.Kind = string.Empty;
        }

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Kind = kind;
        }

        public string PrintPet()
        {
            if (this.Name == string.Empty && this.Age == 0 && this.Kind ==string.Empty)
            {
                return $"Room empty";
            }
            return $"{this.Name} {this.Age} {this.Kind}";
        }

        public int CompareTo(Pet other)
        {
            int nameCompare = this.Name.CompareTo(other.Name);
            int ageCompare = this.Age.CompareTo(other.Age);

            if (nameCompare != 0)
            {
                return nameCompare;
            }

            if (ageCompare != 0)
            {
                return ageCompare;
            }

            return this.Kind.CompareTo(other.Kind);
        }
    }
}
