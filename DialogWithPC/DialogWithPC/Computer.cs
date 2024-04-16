﻿namespace DialogWithPCTests
{
    public class Computer
    {
        private Topic currentTopic;
        private AnswerHandler answerHandler;
        private string currentPhrase;

        public Computer()
        {
            this.answerHandler = new AnswerHandler();
        }
        public void SetTopic(Topic topic)
        {
            this.currentTopic = topic;
        }
    }
}