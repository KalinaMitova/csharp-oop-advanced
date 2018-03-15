namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using Models.Units;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        private const string PathUnit = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitTypeInput)
        {

            Type unitType = Type.GetType(PathUnit + unitTypeInput);
            IUnit unit =(IUnit) Activator.CreateInstance(unitType);
            return unit;
        }
    }
}
