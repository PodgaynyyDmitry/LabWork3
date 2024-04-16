using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DialogWithPCTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void Computer_ClassCreation_Test()
        {
            Computer computer = new Computer();
            Assert.IsNotNull(computer);
        }
        [TestMethod]
        public void ProcessUseranswer_Test()
        {
            Computer computer = new Computer();
            Status expectedProcessingStatus = Status.NORMAL_WORK;
            Status actualProcessingStatus = computer.ProcessUserAnswer("ответ");
            Assert.AreEqual(expectedProcessingStatus, actualProcessingStatus);
        }
        [TestMethod]
        public void ProcessUseranswer_EmptyAnswer_Test()
        {
            Computer computer = new Computer();
            Status expectedProcessingStatus = Status.EMPTY_ANSWER;
            Status actualProcessingStatus = computer.ProcessUserAnswer("");
            Assert.AreEqual(expectedProcessingStatus, actualProcessingStatus);
        }
    }
}
