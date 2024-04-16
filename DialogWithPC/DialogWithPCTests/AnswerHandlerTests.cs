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
    }
}
