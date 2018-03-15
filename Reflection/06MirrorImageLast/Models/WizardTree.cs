namespace _06MirrorImageLast.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using System.Linq;

    public class WizardTree
    {
        private Dictionary<int, IWizard[]> wizards;
        private HashSet<IWizard> wizardsByID;
        private IWizard wizardRoot;
        private int count;

        public WizardTree(IWizard wizardRoot)
        {
            this.wizardRoot = wizardRoot;
            this.wizardsByID = new HashSet<IWizard> { wizardRoot};
            this.wizards = new Dictionary<int, IWizard[]>();
        }

        public Dictionary<int, IWizard[]> Wizards
        {
            get { return this.wizards; }

            set { this.wizards = value; }
        }

        private void AddAction (int index)
        {
            if (this.wizardsByID.Any(w => w.Id == index))
            {
                int magicPower = (this.wizardsByID.First(w => w.Id == index).MagicPower) / 2;

                IWizard wizardLeftChild = new BasicWizard(this.wizardRoot.Name, magicPower, ++count);
                IWizard wizardRightChild = new BasicWizard(this.wizardRoot.Name, magicPower, ++count);

                this.Wizards.Add(index, new IWizard[] { wizardLeftChild, wizardRightChild });
                this.wizardsByID.Add(wizardLeftChild);
                this.wizardsByID.Add(wizardRightChild);
            } 
        }

        public void ReflestionAction(int index)
        {

            if (index == 0 && this.wizards.Count == 0)
            {
                Console.WriteLine($"{this.wizardRoot.Name} {this.wizardRoot.Id} casts Reflection");
                AddAction(0);
            }     
            else if (this.wizards.ContainsKey(index))
            {
                IWizard curent = this.wizardsByID.First(w => w.Id == index);
                Console.WriteLine($"{curent.Name} {curent.Id} casts Reflection");
                Stack<IWizard> wizardToCheck = new Stack<IWizard>();
                index = ForeachTree(index, wizardToCheck);

                AddAction(index);

                while (wizardToCheck.Count > 0)
                {
                    curent = wizardToCheck.Pop();
                    Console.WriteLine($"{curent.Name} {curent.Id} casts Reflection");
                    index = curent.Id;
                    index = ForeachTree(index, wizardToCheck);
                    AddAction(index);
                }
            }
            else if ((!this.wizards.ContainsKey(index) && this.wizardsByID.Any(w => w.Id == index)))
            {
                IWizard curent = this.wizardsByID.First(w => w.Id == index);
                Console.WriteLine($"{curent.Name} {curent.Id} casts Reflection");
                AddAction(index);
            }
        }

        public void FireballAction(int index)
        {

            if (index == 0 && this.wizards.Count == 0)
            { 
                Console.WriteLine($"{this.wizardRoot.Name} {this.wizardRoot.Id} casts Fireball for {this.wizardRoot.MagicPower} damage");
            }
            else if (this.wizards.ContainsKey(index))
            {
                IWizard curent = this.wizardsByID.First(w => w.Id == index);
                Console.WriteLine($"{curent.Name} {curent.Id} casts Fireball for {curent.MagicPower} damage");
                Stack<IWizard> wizardToCheck = new Stack<IWizard>();
                index = ForeachTreeFireball(index, wizardToCheck);

                while (wizardToCheck.Count > 0)
                {
                    curent = wizardToCheck.Pop();
                    Console.WriteLine($"{curent.Name} {curent.Id} casts Fireball for {curent.MagicPower} damage");
                    index = curent.Id;
                    index = ForeachTreeFireball(index, wizardToCheck);
                }
            }
            else if ((!this.wizards.ContainsKey(index) &&  this.wizardsByID.Any(w => w.Id == index)))
            {
                IWizard curent = this.wizardsByID.First(w => w.Id == index);
                Console.WriteLine($"{curent.Name} {curent.Id} casts Fireball for {curent.MagicPower} damage");
            }
        }

        private int ForeachTree(int index, Stack<IWizard> wizardToCheck)
        {
            while (this.wizards.ContainsKey(index))
            {
                IWizard wizardLeft = this.wizards[index][0];
                IWizard wizardRight = this.wizards[index][1];
                wizardToCheck.Push(wizardRight);
                Console.WriteLine($"{wizardLeft.Name} {wizardLeft.Id} casts Reflection");
                index = wizardLeft.Id;
            }

            return index;
        }

        private int ForeachTreeFireball(int index, Stack<IWizard> wizardToCheck)
        {
            while (this.wizards.ContainsKey(index))
            {
                IWizard wizardLeft = this.wizards[index][0];
                IWizard wizardRight = this.wizards[index][1];
                wizardToCheck.Push(wizardRight);
                Console.WriteLine($"{wizardLeft.Name} {wizardLeft.Id} casts Fireball for {wizardLeft.MagicPower} damage");
                index = wizardLeft.Id;
            }

            return index;
        }
    }
}
