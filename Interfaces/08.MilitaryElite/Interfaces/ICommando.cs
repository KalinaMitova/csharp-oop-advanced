
namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface ICommando
    {
        List<Mission> Missions { get; }
    }
}
