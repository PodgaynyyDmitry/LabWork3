
namespace DialogWithPCTests
{
    public class Dialog
    {
        private List<Topic> topics;
        private Computer computer;

        public Dialog(List<Topic> topics, Computer computer)
        {
            this.topics = topics;
            this.computer = computer;
        }
    }
}