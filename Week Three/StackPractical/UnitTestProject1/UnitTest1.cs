using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackPractical;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_OnEmptyStack_ReturnTrue()
        {
            Stack emptyStack = new Stack();
            bool expected = true;
            bool actual = emptyStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
    }
}
