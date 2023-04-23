
namespace ChatGptWizard.Infrastructure.Context
{
    public class Message
    {
        public int id { get; set; }
        public string text { get; set; }
        public DateTime createAt { get; set; }
    }
}
