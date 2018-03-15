namespace _06MirrorImage.Models
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    public class WizardTree : IEnumerable<int>
    {
        private WizardNode root;
        private List<WizardNode> nodeList;
        private int count;

        public WizardTree (IWizard root)
        {
            this.nodeList = new List<WizardNode>();
            this.root = CreatWizardNode(root);
        }

        public void AddWizards()
        {
            if (count == 0)
            {
                SetWizardLeaf(this.root);
            }

            else
            {
                int start = this.count / 2;
                int end = this.count;

                for (int i = start; i < end; i+=2)
                {
                    SetWizardLeaf(this.nodeList[i]);
                }
            }

        }

        public void FirebollAction(int wizardID)
        {
            Type wizardNodeType = typeof(WizardNode);
            FieldInfo mainNodeField = wizardNodeType.GetField("mainWizard", BindingFlags.NonPublic | BindingFlags.Instance);

            Type wizardType = typeof(Wizard);
            FieldInfo magicPowerWizardField = wizardType.GetField("magicPower", BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var nodeID in this)
            {
                if (nodeID >= wizardID)
                {
                    IWizard mainWizard = (IWizard) mainNodeField.GetValue(this.nodeList[nodeID]);
                    int magicPower = (int)magicPowerWizardField.GetValue(mainWizard);
                    Console.WriteLine($"Oz {nodeID} casts Fireball for {magicPower} damage") ;
                }
            }
        }

        public void ReflectionAction (int wizardID)
        {
            foreach (var nodeID in this)
            {
                if (nodeID >= wizardID)
                {
                    Console.WriteLine($"Oz {nodeID} casts Reflection");
                }
            }
        }

        private void SetWizardLeaf(WizardNode node)
        {
            IWizard wizard1 = MakeWizardWithID(node);
            WizardNode wizardNodeFirstLeaf = CreatWizardNode(wizard1);
            SetFirstWizardNodeLeaf(node, wizardNodeFirstLeaf);

            IWizard wizard2 = MakeWizardWithID(node);
            WizardNode wizardNodeSecondLeaf = CreatWizardNode(wizard2);
            SetSecondWizardNodeLeaf(node, wizardNodeSecondLeaf);
        }

        private WizardNode CreatWizardNode(IWizard wizard)
        {
            Type wizardNodeType = typeof(WizardNode);
            ConstructorInfo nodeCostructor = wizardNodeType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(IWizard) }, null);
            WizardNode wizardNode = (WizardNode)nodeCostructor.Invoke(new object[] { wizard });
            FieldInfo idWizardNodeField = wizardNodeType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);
            idWizardNodeField.SetValue(wizardNode, count);
            this.nodeList.Add(wizardNode);
            return wizardNode;
        }

        private IWizard MakeWizardWithID(WizardNode rootNode)
        {
            IWizard wizard = new BasicWizard();
            Type wizardType = typeof(Wizard);
            FieldInfo idField = wizardType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);
            idField.SetValue(wizard, ++count);

            Type wizardNodeType = typeof(WizardNode);
            IWizard rootWizard =(IWizard) wizardNodeType.GetField("mainWizard", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(rootNode);
            FieldInfo magicPowerField = wizardType.GetField("magicPower", BindingFlags.NonPublic | BindingFlags.Instance);
            magicPowerField.SetValue(wizard, (int)magicPowerField.GetValue(rootWizard) / 2);
           
            return wizard; 
        }

        private void SetFirstWizardNodeLeaf (WizardNode nodeRoot, WizardNode nodeLeaf)
        {
            Type wizardNodeType = typeof(WizardNode);
            FieldInfo wizardNodeField = wizardNodeType.GetField("firstImageWizard", BindingFlags.NonPublic | BindingFlags.Instance);
            wizardNodeField.SetValue(nodeRoot, nodeLeaf);

        }

        private void SetSecondWizardNodeLeaf(WizardNode nodeRoot, WizardNode nodeLeaf)
        {
            Type wizardNodeType = typeof(WizardNode);
            FieldInfo wizardNodeField = wizardNodeType.GetField("secondImageWizard", BindingFlags.NonPublic | BindingFlags.Instance);
            wizardNodeField.SetValue(nodeRoot, nodeLeaf);
        }

        public IEnumerator<int> GetEnumerator()
        {
            Type wizardNodeType = typeof(WizardNode);
            FieldInfo mainNodeField = wizardNodeType.GetField("mainWizard", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo firstImageWizardField = wizardNodeType.GetField("firstImageWizard", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo secondImageWizardField = wizardNodeType.GetField("secondImageWizard", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo idWizardNodeField = wizardNodeType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);

            Type wizardType = typeof(Wizard);
            FieldInfo idWizardField = wizardType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);
            
            for (int i = 0; i < (this.nodeList.Count / 2); i++)
            {
                WizardNode current = nodeList[i];
                int idCurrentNode = (int)idWizardNodeField.GetValue(current);

                IWizard mainWizardCurrent = (IWizard)mainNodeField.GetValue(current);
                int idParentWizard = (int)idWizardField.GetValue(mainWizardCurrent);

                WizardNode firstImageWizardCurrent = (WizardNode)firstImageWizardField.GetValue(current);
                int firstChildWizard = (int)idWizardNodeField.GetValue(firstImageWizardCurrent);

                WizardNode secondImageWizardCurrent = (WizardNode)secondImageWizardField.GetValue(current);
                int secondChildWizard = (int)idWizardNodeField.GetValue(secondImageWizardCurrent);

                if (i == 0)
                {
                    yield return idParentWizard;
                }

                yield return firstChildWizard;
                yield return secondChildWizard;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
