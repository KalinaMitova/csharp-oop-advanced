using System;

namespace _04.Telephony
{
    public class StartUp
    {
        public static void Main()
        {          
            Smartphone phone = new Smartphone();

            string[] dataPhone = Console.ReadLine().Split(new[] { ' '});

            string[] dataWeb = Console.ReadLine().Split(new[] { ' '});

            Console.Write(phone.CallAtherPhone(dataPhone));

            Console.Write(phone.BrowseSite(dataWeb));
        }
    }
}
