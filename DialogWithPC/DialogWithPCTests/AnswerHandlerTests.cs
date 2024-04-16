using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogWithPCTests
{
    [TestClass]
    public class AnswerHandlerTests
    {
        [TestMethod]
        public void AnswerHandler_ClassCreatin_Test()
        {
            AnswerHandler answerHandler = new AnswerHandler();
            Assert.IsNotNull(answerHandler);
        }
        [TestMethod]
        public void AnswerHandler_CheckDialogFinishStatus_Test()
        {
            AnswerHandler answerHandler = new AnswerHandler();
            bool isDialogFinished = answerHandler.CheckDialogFinishStatus("ответ");
            Assert.IsFalse(isDialogFinished);
        }
        [TestMethod]
        public void AnswerHandler_CheckDialogFinishStatus_True_Test()
        {
            AnswerHandler answerHandler = new AnswerHandler();
            bool isDialogFinished = answerHandler.CheckDialogFinishStatus("Я хочу завершить диалог");
            Assert.IsTrue(isDialogFinished);
        }
    }
}
