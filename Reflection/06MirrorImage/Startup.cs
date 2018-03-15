namespace _06MirrorImage
{
    using System;
    using Contracts;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            IWizard wizard = new BasicWizard("Oz", 36);
            WizardTree tree = new WizardTree(wizard);

            tree.AddWizards();
            tree.AddWizards();
            tree.AddWizards();
            tree.AddWizards();

            tree.FirebollAction(2);
        }
    }
}
