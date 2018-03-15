using System;

namespace _07.CustomList
{
   public class Sorter
    {
       
        public static CustomList<T> Sort<T>( CustomList<T> mylist)
            where T : IComparable
        {
            

            while (true)
            {
                bool isSorted = true;
                int listLength = mylist.Count();

                for (int i = 0; i < listLength - 1; i++)
                {
                    if (mylist[i].CompareTo(mylist[i + 1]) > 0)
                    {
                        T holder = mylist[i];
                        mylist[i] = mylist[i + 1];
                        mylist[i + 1] = holder;
                        isSorted = false;
                    }
                }

                if (isSorted)
                {
                    break;
                }
            }

            return mylist;
        }
    }
}
