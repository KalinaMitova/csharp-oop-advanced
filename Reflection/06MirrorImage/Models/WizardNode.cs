using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MirrorImage.Models
{
    using Contracts;

    public class WizardNode
    {
        private IWizard mainWizard;
        private WizardNode firstImageWizard;
        private WizardNode secondImageWizard;
        private int id;

        private WizardNode(IWizard mainWizard)
        {
            this.mainWizard = mainWizard;
        }
    }
}
