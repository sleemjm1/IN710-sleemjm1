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

        [TestMethod]
        public void IsEmpty_OnStackWithOneString_ReturnFalse()
        {
            Node testNode = new Node("Test");
            Stack testStack = new Stack();
            testStack.Push(testNode);
            bool expected = false;
            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_OnNewlyEmptyStack_ReturnTrue()
        {
            Node testNode = new Node("Test");
            Stack testStack = new Stack();
            testStack.Push(testNode);
            testStack.Pop();
            bool expected = true;
            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_OnEmptyStack_ReturnExceptionMessage()
        {
            Stack testStack = new Stack();
            string expected = "Stack is empty.";
            string actual = testStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_OnPopulatedStack_ReturnString()
        {
            Node testNode = new Node("test");
            Stack testStack = new Stack();
            testStack.Push(testNode);
            string expected = "test";
            string actual = testStack.Peek();

            Assert.AreEqual(expected, actual);
        }
    }
}
