
namespace _03_Ferrari
{
    public class Ferrari : ICar
    {
        public const string Model = "488-Spider";

        private string driverName;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        public string DriverName
        {
            get { return this.driverName; }

            private set { this.driverName = value; }
        }

        public string Brakes()
        {
            return  "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
    }
}
