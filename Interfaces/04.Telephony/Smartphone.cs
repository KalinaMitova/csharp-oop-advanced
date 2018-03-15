using System.Text;

namespace _04.Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string BrowseSite(params string[] webSiteURL)
        {
            StringBuilder output = new StringBuilder();
           
            foreach (var url in webSiteURL)
            {
                bool isValidURL = true;

                foreach (var symbol in url)
                {
                    if (char.IsDigit(symbol))
                    {
                        output.AppendLine("Invalid URL!");
                        isValidURL = false;
                        break;
                    }
                }

                if (isValidURL)
                {
                    output.AppendLine($"Browsing: {url}!");
                }
            }

            return output.ToString();
        }

        public string CallAtherPhone(params string[] phonesNumbers)
        {
            StringBuilder output = new StringBuilder();
            
            foreach (var number in phonesNumbers)
            {
                bool isValidNumber = true;
                foreach (var digit in number)
                {
                    if (!char.IsDigit(digit))
                    {
                       output.AppendLine( "Invalid number!");
                        isValidNumber = false;
                        break;
                    }
                }

                if (isValidNumber)
                {
                    output.AppendLine($"Calling... {number}");
                }
            }

            return output.ToString();
        }
    }
}
