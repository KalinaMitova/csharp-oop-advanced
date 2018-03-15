using _06.BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.BirthdayCelebrations.Models
{
    public class Pet : INamable, IBirthdatable
    {

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; private set; }

        public string Name { get; private set; }
    }
}
