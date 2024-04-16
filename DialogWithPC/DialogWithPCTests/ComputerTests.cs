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
      
    }
}
