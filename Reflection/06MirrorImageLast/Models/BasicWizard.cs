namespace _06MirrorImageLast.Models
{
    public class BasicWizard : Wizard
    {
        public BasicWizard(string name, int magicPower) 
            : base(name, magicPower)
        {
        }

        public BasicWizard(string name, int magicPower, int id)
            : base(name, magicPower, id)
        {
        }
    }
}
