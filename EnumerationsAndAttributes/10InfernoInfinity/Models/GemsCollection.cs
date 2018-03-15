using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10InfernoInfinity.Models
{
    using Enums;
    using Models.Gems;
    using Interfaces;

    public class GemsCollection 
    {
        private IGem[] gems;

        public GemsCollection(Socket sockets)
        {
            this.gems = FulGemMatrix((int)sockets);
        }

        public void AddGem (int index, IGem gem)
        {
            if (index >= 0 && index <= this.gems.Length)
            {
                gems[index] = gem;
            }
        }

        private IGem[] FulGemMatrix(int count)
        {
            IGem[] gems = new IGem[count];
            for (int i = 0; i < count; i++)
            {
                gems[i] = new EmptyGem();
            }

            return gems;
        }

        public void RemoveGem(int index)
        {
            if (index >= 0 && index <= this.gems.Length)
            {
                this.gems[index] = new EmptyGem();
            }
        }

        public string PrintGemsState()
        {
            return $"+{this.gems.Sum(g => g.Strength)} Strength, +{this.gems.Sum(g => g.Agility)} Agility, +{this.gems.Sum(g => g.Vitality)} Vitality";
        }

        public int AllStrength => this.gems.Sum(g => g.Strength);

        public int AllAgility => this.gems.Sum(g => g.Agility);

    }
}
