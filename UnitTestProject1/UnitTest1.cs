using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionOfNumberProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = program.Add(5, 10);
            Assert.AreEqual(15, result);
        }
    }
}

