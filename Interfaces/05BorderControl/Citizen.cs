using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BorderControl
{
    public class Citizen : IEntrants
    {
        private string name;

        private int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.ID = id;     
        }

        public string ID {get; set;}
    }
}
