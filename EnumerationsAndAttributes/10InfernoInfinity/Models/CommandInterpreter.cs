using System;
using System.Collections.Generic;

namespace _10InfernoInfinity.Models
{
    using Interfaces;
    using Atrtributes;
    public class CommandInterpreter
    {
        private Dictionary<string, IWeapon> weapons;
        private string[] input;
        private WeaponFactory weaponFactory;
        private GemFactory gemFactory;
        object[] allAtributes;

        public CommandInterpreter  (string[] input, Dictionary<string, IWeapon> weapons, object[] allAtributes)
        {
            this.input = input;
            this.weapons = weapons;
            this.weaponFactory = new WeaponFactory();
            this.gemFactory = new GemFactory();
            this.allAtributes = allAtributes;
        }

        public void ParseCommand()
        {
            string command = this.input[0];

            switch (command)
            {
                case "Create":
                    {
                        string weaponName = this.input[2];
                        try
                        {
                            this.weapons.Add(weaponName, weaponFactory.CreateWeapon(this.input));
                        }
                        catch{}
                    }  break;

                case "Add":
                    {
                        string weaponName = this.input[1];
                        int index = int.Parse(this.input[2]);
                        string[] gemInput = this.input[3].Split();

                        try
                        {
                            this.weapons[weaponName].AddGemToWeapon(index, this.gemFactory.CreateGem(gemInput));
                        }
                        catch {}
                    } break;

                case "Remove":
                    {
                        string weaponName = this.input[1];
                        int index = int.Parse(this.input[2]);
                        try
                        {
                            this.weapons[weaponName].RemoveGemFromWeapon(index);
                        }
                        catch { }
                    }
                    break;

                case "Print":
                    {
                        string weaponName = this.input[1];
                        try
                        {
                            OutputWriter.PrintMessageOnNewLine(this.weapons[weaponName].ToString());
                        }
                        catch { }
                    } break;

                case "Author":
                    {
                        foreach (AutorAttribute item in allAtributes)
                        {
                            OutputWriter.PrintMessageOnNewLine($"Author: {item.author}");
                        }
                    }
                    break;

                case "Revision":
                    {
                        foreach (AutorAttribute item in allAtributes)
                        {
                            OutputWriter.PrintMessageOnNewLine($"Revision: {item.revision}");
                        }
                    }
                    break;

                case "Description":
                    {
                        foreach (AutorAttribute item in allAtributes)
                        {
                            OutputWriter.PrintMessageOnNewLine($"Class description: {item.description}");
                        }
                    }
                    break;

                case "Reviewers":
                    {
                        foreach (AutorAttribute item in allAtributes)
                        {
                            OutputWriter.PrintMessageOnNewLine($"Reviewers: {string.Join(", ", item.reviewers)}");
                        }
                    }
                    break;


            }
        }
    }
}
