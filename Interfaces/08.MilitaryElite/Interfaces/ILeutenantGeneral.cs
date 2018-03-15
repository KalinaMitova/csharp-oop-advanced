
namespace _08.MilitaryElite.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface ILeutenantGeneral
    {
        List<Soldier> Privates { get; }
    }
}
