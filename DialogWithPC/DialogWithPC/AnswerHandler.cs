


namespace DialogWithPCTests
{
    public class AnswerHandler
    {
        private string[] finishDialogPhrases = {"Я хочу завершить диалог","Я хочу закончить беседу","Я наговорился","Мне надоело"};

        public bool CheckAnswerPositivity(string v)
        {
            return true;
        }

        public bool CheckDialogFinishStatus(string v)
        {
            foreach (string phrase in finishDialogPhrases)
            {
                if (phrase == v)
                    return true;
            }
            return false;
        }

        public bool CheckTopicChangeStatus(string v)
        {
            if(v=="Я хочу поговорить на другую тему")
                return true;
            return false;
        }
    }
}