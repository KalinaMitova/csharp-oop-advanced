using System;

namespace _08PetClinic
{
    using Models;
    public class CommandIterpretor
    {
        private string[] input;
        private ClinicsNetwork clinicNet;

        public CommandIterpretor(string[] input, ClinicsNetwork clinicNet)
        {
            this.input = input;
            this.clinicNet = clinicNet;
        }

        public void ParseCommand ()
        {
            string command = this.input[0];

            switch (command)
            {
                case "Create":
                        CreateFactory();
                    break;

                case "Add":
                        AddPetToClinic();
                    break;

                case "Release":
                    ReleasePetFromClinic();
                    break;

                case "HasEmptyRooms":
                    HasEmptyRoomsinClinic();
                    break;

                case "Print":
                    PrintRoomsinClinic();
                    break;
            }
        }

        private void PrintRoomsinClinic()
        {
            string clinicName = this.input[1];
            if (this.input.Length == 2)
            {    
                OutputWriter.WriteMessage(this.clinicNet.PrintClinicByName(clinicName));
            }

            else if (this.input.Length == 3)
            {
                int room = int.Parse(this.input[2]);
                try
                {
                    OutputWriter.WriteMessageOnNewLine(this.clinicNet.PrintSpecifiedRoomInClinic(clinicName, room));

                }
                catch (Exception e)
                {
                    OutputWriter.WriteMessageOnNewLine(e.Message);
                }
            }
           
        }

        private void HasEmptyRoomsinClinic()
        {
            string clinicName = this.input[1];
            OutputWriter.WriteMessageOnNewLine(this.clinicNet.HasEmptyRoomsInClinic(clinicName).ToString());
        }

        private void ReleasePetFromClinic()
        {
            string clinicName = this.input[1];
            OutputWriter.WriteMessageOnNewLine(this.clinicNet.ReleasePetFromClinic( clinicName).ToString());
        }

        private void AddPetToClinic()
        {
            string petName = this.input[1];
            string clinicName = this.input[2];
            OutputWriter.WriteMessageOnNewLine(this.clinicNet.AddPetByClinic(petName, clinicName).ToString());
        }

        private void CreateFactory()
        {
            string petOrClinic = this.input[1];
            if (petOrClinic == "Pet")
            {
                string name = this.input[2];
                int age = int.Parse(this.input[3]);
                string kind = this.input[4];

                try
                {
                    Pet pet = new Pet(name, age, kind);
                    this.clinicNet.AddPetToAllPet(pet);
                }
                catch { }
            }
            else if (petOrClinic == "Clinic")
            {
                string name = this.input[2];
                int rooms = int.Parse(this.input[3]);

                try
                {
                    Clinic clinic = new Clinic(name, rooms);
                    this.clinicNet.AddClinic(clinic);
                }
                catch (ArgumentException)
                {
                    OutputWriter.WriteMessageOnNewLine("Invalid Operation!");
                }

            }
        }
    }
}
