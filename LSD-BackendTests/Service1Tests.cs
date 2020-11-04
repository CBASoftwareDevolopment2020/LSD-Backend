using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSD_Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSD_Backend.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void TestTrue()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void TestFail()
        {
            Assert.IsTrue(false);
        }
    }
}