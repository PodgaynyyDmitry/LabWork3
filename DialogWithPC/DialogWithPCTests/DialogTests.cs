using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogWithPCTests
{
    [TestClass]
    public class DialogTests
    {
        [TestMethod]
        public void Dialog_ClassCreation_Test() 
        {
            List<Topic> topics = new List<Topic>();
            Computer computer = new Computer();
            Dialog dialog = new Dialog(topics, computer);
            Assert.IsNotNull(dialog);
        }
      

    }
}
