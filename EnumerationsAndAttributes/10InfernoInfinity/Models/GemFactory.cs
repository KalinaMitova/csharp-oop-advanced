namespace _10InfernoInfinity.Models
{
    using System;
    using Enums;
    using Interfaces;
    using Gems;

    public class GemFactory
    {
        public IGem CreateGem(string[] gemInput)
        {
            string gemClarityString = gemInput[0];

            ClarityLevel gemClarity = (ClarityLevel)Enum.Parse(typeof(ClarityLevel), gemClarityString);

            string gemName = gemInput[1];

            switch (gemName)
            {
                case "Amethyst":
                    return new Amethyst(gemClarity, gemName);

                case "Emerald":
                    return new Emerald(gemClarity, gemName);

                case "Ruby":
                    return new Ruby(gemClarity, gemName);

                default: throw new OperationCanceledException();
            }

        }
    }
}
