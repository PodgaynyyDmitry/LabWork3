


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
        private Phrases currentPhrase;
        public Computer()
        {
            this.answerHandler = new AnswerHandler();
        }
        public string ChooseTopic(List<Topic> topics, string v)
        {
            string result = "";
            foreach(Topic topic in topics)
            {
                if(v==topic.GetTopic())
                {
                    result = topic.GetTopic();
                    currentTopic = topic;
                }
                    
            }
            return result;
        }

        public Status ProcessUserAnswer(string v)
        {
            if (answerHandler.CheckAnswerEmpty(v))
                return Status.EMPTY_ANSWER;
            if (answerHandler.CheckDialogFinishStatus(v))
                return Status.DIALOG_FINISH;
            if(answerHandler.CheckTopicChangeStatus(v))
                return Status.TOPIC_CHANGE;
            return Status.NORMAL_WORK;
        }

        public void SetTopic(Topic topic)
        {
            this.currentTopic = topic;
        }
        public Topic GetTopic() { return currentTopic; }
        public void SetCurrentPhrase(Phrases phrase)
        {

            currentPhrase = phrase;
        }

        public string? SayPhrase(string answer)
        {
            string result = "";
            if(answerHandler.CheckAnswerPositivity(answer))
                result=currentPhrase.GetPositivePhrase();
            else
               result=currentPhrase.GetNegativePhrase();

            if (currentTopic.GetPhrases().IndexOf(currentPhrase)< currentTopic.GetPhrases().Count-1)
            {
                currentPhrase = currentTopic.GetPhrases()[currentTopic.GetPhrases().IndexOf(currentPhrase) + 1];
                return result;
            }
            else
                return result + " На этом все)";
               
        }
    }
}