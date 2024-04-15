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
            Topic topic = new Topic("Путешествия",new List<Phrases>());
            Assert.IsNotNull(topic);
        }
    }
}
