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
        [TestMethod]
        public void ProcessUseranswer_FinishDialog_Test()
        {
            Computer computer = new Computer();
            Status expectedProcessingStatus = Status.DIALOG_FINISH;
            Status actualProcessingStatus = computer.ProcessUserAnswer("Я хочу завершить диалог");
            Assert.AreEqual(expectedProcessingStatus, actualProcessingStatus);
        }
        [TestMethod]
        public void ProcessUseranswer_ChangeTopic_Test()
        {
            Computer computer = new Computer();
            Status expectedProcessingStatus = Status.TOPIC_CHANGE;
            Status actualProcessingStatus = computer.ProcessUserAnswer("Я хочу поговорить на другую тему");
            Assert.AreEqual(expectedProcessingStatus, actualProcessingStatus);
        }
        [TestMethod]
        public void ChooseTopic_Test()
        {
            Computer computer = new Computer();
            List<Topic> topics = new List<Topic> { new Topic("Путешествия",new List<Phrases>()), new Topic("Альпинизм", new List<Phrases>())};
            string expectedTopic = "Альпинизм";
            string actualTopic = computer.ChooseTopic(topics,"Альпинизм");
            Assert.AreEqual(expectedTopic, actualTopic);
        }
        [TestMethod]
        public void ChooseTopic_NoSuchTopic_Test()
        {
            Computer computer = new Computer();
            List<Topic> topics = new List<Topic> { new Topic("Путешествия", new List<Phrases>()), new Topic("Альпинизм", new List<Phrases>()) };
            string expectedTopic = "";
            string actualTopic = computer.ChooseTopic(topics, "Рыбалка");
            Assert.AreEqual(expectedTopic, actualTopic);
        }
    }
}
