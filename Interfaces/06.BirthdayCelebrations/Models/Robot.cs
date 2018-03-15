
namespace _06.BirthdayCelebrations
{
    public class Robot : IIDable
    {
        private string model;

        public Robot (string model, string id)
        {
            this.model = model;
            this.ID = id;  
        }

        public string ID { get; private set; }

    }
}
