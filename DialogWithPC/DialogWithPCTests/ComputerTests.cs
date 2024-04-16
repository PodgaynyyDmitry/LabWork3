using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
