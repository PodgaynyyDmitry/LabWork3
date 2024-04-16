
namespace DialogWithPCTests
{
    public enum Status
    {
        NORMAL_WORK,
        DIALOG_FINISH,
        TOPIC_CHANGE,
        EMPTY_ANSWER
    }
    public class Computer
    {
        private Topic currentTopic;
        private AnswerHandler answerHandler;
        private string currentPhrase;

        public Computer()
        {
            this.answerHandler = new AnswerHandler();
        }

        public Status ProcessUserAnswer(string v)
        {
            return Status.NORMAL_WORK;
        }

        public void SetTopic(Topic topic)
        {
            this.currentTopic = topic;
        }
    }
}