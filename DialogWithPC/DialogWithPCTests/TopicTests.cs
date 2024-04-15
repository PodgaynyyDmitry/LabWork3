using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogWithPCTests
{
    [TestClass]
    public class TopicTests
    {
        [TestMethod]
        public void Topic_ClassCreation_Test()
        {
            string topic = "Путешествия";
            List<Phrases> phrases = new List<Phrases>();
            Topic dilaogTopic = new Topic(topic,phrases);
            Assert.IsNotNull(topic);
        }
        [TestMethod]
        public void Topic_GetTopic_Test()
        {
            string topic = "Путешествия";
            List<Phrases> phrases = new List<Phrases>();
            Topic dilaogTopic = new Topic(topic, phrases);
            string actualTopic = dilaogTopic.GetTopic();
            Assert.AreEqual(topic, actualTopic);
        }
    }
}
