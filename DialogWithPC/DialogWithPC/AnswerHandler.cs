


namespace DialogWithPCTests
{
    public class AnswerHandler
    {
        private string[] finishDialogPhrases = {"Я хочу завершить диалог","Я хочу закончить беседу","Я наговорился","Мне надоело"};
        private string[] negativeAnswerPhrases = {"не ","нет","к сожалению" };

        public bool CheckAnswerPositivity(string v)
        {
            foreach(string phrase in negativeAnswerPhrases)
            {
                if (v.Contains(phrase))
                    return false;
            }
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