using System;
using System.Collections.Generic;
using System.Text;

namespace _08PetClinic
{
    public class Clinic //: IEnumerable<int>
    {
        public string Name { get; private set; }
        private int rooms;
        public Pet[] RoomsInfo { get; private set; }
        private int middleIndex;

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
            this.middleIndex = rooms / 2;
            this.RoomsInfo = FillRooms();
        }

        public int Rooms
        {
            get { return this.rooms; }

            private set
            {
                if (value %2 == 0)
                {
                    throw new ArgumentException("The number of rooms must be odd!");
                }

                this.rooms = value;
            }
        }

       public bool AddPet(Pet pet)
        {
            foreach (var item in GetEnumeratorAdd())
            {
                this.RoomsInfo[item] = pet;
                return true;
            }

            return false;
        }

        public bool ReleasePet()
        {
            foreach (var item in GetEnumeratorRelease())
            {
                this.RoomsInfo[item] = new Pet();
                return true;
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            Pet nullPet = new Pet();
            foreach (var roomPet in GetEnumeratorPrint())
            {
                if (roomPet.CompareTo(nullPet) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public string PrintClinic()
        {
            StringBuilder output = new StringBuilder();
            foreach (var animal in GetEnumeratorPrint())
            {
                output.AppendLine(animal.PrintPet());
            }

            return output.ToString();
        }

        public string PrintSpecifiedRoom (int room)
        {
            if (room-1 >= this.rooms || rooms-1<0)
            {
                throw new OperationCanceledException($"Хo room with this number!");
            }
                return $"{this.RoomsInfo[room - 1].PrintPet()}";
        }

        private Pet[] FillRooms()
        {
            this.RoomsInfo = new Pet[this.rooms];
            for (int i = 0; i < this.Rooms; i++)
            {
                this.RoomsInfo[i] = new Pet();
            }
            return this.RoomsInfo;
        }

        private IEnumerable<int> GetEnumeratorAdd()
        {
            Pet nullPet = new Pet();
            int countIndex = 1;

            if (this.RoomsInfo[middleIndex].CompareTo(nullPet) == 0)
            {
                yield return middleIndex;
            }

            while (middleIndex + countIndex < this.Rooms)
            {
                if (this.RoomsInfo[middleIndex - countIndex].CompareTo(nullPet) == 0)
                {
                    yield return middleIndex - countIndex;
                    break;
                }

                if (this.RoomsInfo[middleIndex + countIndex].CompareTo(nullPet) == 0)
                {
                    yield return middleIndex + countIndex;
                    break;
                }
                countIndex++;
            }
        }

        private IEnumerable<Pet> GetEnumeratorPrint()
        {
            for (int i = 0; i < this.RoomsInfo.Length; i++)
            {
                yield return this.RoomsInfo[i];
            }
        }

       private IEnumerable<int> GetEnumeratorRelease()
       {
            Pet nullPet = new Pet();

            if (this.RoomsInfo[middleIndex].CompareTo(nullPet) != 0)
           {
               yield return middleIndex;
           }

            for (int i = middleIndex + 1; i < this.RoomsInfo.Length; i++)
            {
                if (this.RoomsInfo[i].CompareTo(nullPet) != 0)
                {
                    yield return i;
                    break;
                }
            }

            for (int i = 0; i < middleIndex; i++)
            {
                if (this.RoomsInfo[i].CompareTo(nullPet) != 0)
                {
                    yield return i;
                    break;
                }
            }
        }
    }
}
