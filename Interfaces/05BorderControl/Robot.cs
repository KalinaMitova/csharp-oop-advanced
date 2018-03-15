
namespace _05BorderControl
{
    public class Robot : IEntrants
    {
        private string model;

        public Robot (string model, string id)
        {
            this.model = model;
            this.ID = id;  
        }

        public string ID { get; set; }

    }
}
