﻿



namespace DialogWithPCTests
{
    public class Topic
    {
        private string topic;
        private List<Phrases> phrases;

        public Topic(string topic, List<Phrases> phrases)
        {
            this.topic = topic;
            this.phrases = phrases;
        }

        public List<Phrases> GetPhrases()
        {
            return phrases;
        }

        public string GetTopic()
        {
            return topic;
        }
    }
}