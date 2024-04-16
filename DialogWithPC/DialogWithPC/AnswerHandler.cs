
namespace DialogWithPCTests
{
    public class AnswerHandler
    {
        private string[] finishDialogPhrases = {"Я хочу завершить диалог","Я хочу закончить беседу","Я наговорился","Мне надоело"};
        public bool CheckDialogFinishStatus(string v)
        {
            foreach (string phrase in finishDialogPhrases)
            {
                if (phrase == v)
                    return true;
            }
            return false;
        }
    }
}