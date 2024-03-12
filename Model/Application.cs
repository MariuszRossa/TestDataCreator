using System.ComponentModel;

namespace TestDataCreator.Model
{
    public class Application
    {
        public int Id { get; set; }
        public required string Firm { get; set; }
        public string Job { get; set; } = string.Empty;
        public string Decription { get; set; } = string.Empty;
        public ServiceName ServiceName { get; set; }
        public bool AgreementAccepted { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
