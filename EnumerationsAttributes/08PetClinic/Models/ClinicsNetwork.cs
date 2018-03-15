using System;
using System.Collections.Generic;

namespace _08PetClinic.Models
{
    public class ClinicsNetwork
    {
        private Dictionary<string, Clinic> clinicsNet;
        private Dictionary<string, Pet> allPet;

        public ClinicsNetwork()
        {
            this.clinicsNet = new Dictionary<string, Clinic>();
            this.allPet = new Dictionary<string, Pet>();
        }

        public void AddClinic (Clinic clinic)
        {
            this.clinicsNet.Add(clinic.Name, clinic);
        }

        public void AddPetToAllPet(Pet pet)
        {
            this.allPet.Add(pet.Name, pet);
        }

        public bool AddPetByClinic(string petName, string clinicName)
        {
            if (this.clinicsNet.ContainsKey(clinicName) && this.allPet.ContainsKey(petName))
            {
                return clinicsNet[clinicName].AddPet(this.allPet[petName]);
            }

            return false;
        }

        public bool ReleasePetFromClinic(string clinicName)
        {
            if (this.clinicsNet.ContainsKey(clinicName) )
            {
                return clinicsNet[clinicName].ReleasePet();
            }

            return false;
        }

        public bool HasEmptyRoomsInClinic(string clinicName)
        {
            if (this.clinicsNet.ContainsKey(clinicName))
            {
                return clinicsNet[clinicName].HasEmptyRooms();
            }
            return false;
        }

        public string PrintClinicByName(string clinicName)
        {
            if (this.clinicsNet.ContainsKey(clinicName))
            {
                return clinicsNet[clinicName].PrintClinic();
            }

            return $"There isn`t a clinic with this name!";
        }

        public string PrintSpecifiedRoomInClinic(string clinicName, int room)
        {
            if (this.clinicsNet.ContainsKey(clinicName))
            {
               return this.clinicsNet[clinicName].PrintSpecifiedRoom(room);
            }
            else
            {
                throw new OperationCanceledException($"No clinic with this name!");
            }
        }
    }
}
