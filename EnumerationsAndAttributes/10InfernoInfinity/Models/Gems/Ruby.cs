using System;
using System.Collections.Generic;
using System.Linq;
namespace _10InfernoInfinity.Models.Gems
{
    using Enums;

    public class Ruby : Gem
    {
        public Ruby(ClarityLevel clarity,string name) 
            : base(clarity, name,  GemStrengthValue.RubyStrenght, GemAgilityValue.RubyAgility, GemVitalityValue.RubyVitality)
        {
        }
    }
}
