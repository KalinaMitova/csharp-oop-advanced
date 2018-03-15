using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02KingsGambit.Interfaces
{
    using Models;

    public interface IRoyalRetinue
    {
        string Type { get; }
        string Name { get; }
        int AvailableLifes { get; }

        void ReactionKingAttaked();
    }
}
