using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionTool;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        IEncrypt iEncrypt;
        [TestMethod]
        public void Encrypt_StringUsingReverse_ReturnEncryptedString()
        {
            iEncrypt = new Reverse();

            string stringToEncrypt = "Hello";
            string expected = "olleH";
            string actual = iEncrypt.PerformEncryption(stringToEncrypt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Decrypt_StringUsingReverse_ReturnDecryptedString()
        {
            iEncrypt = new Reverse();

            string stringToDecrypt = "olleH";
            string expected = "Hello";
            string actual = iEncrypt.PerformDecryption(stringToDecrypt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Encrypt_StringUsingRot_ReturnEncryptedString()
        {
            iEncrypt = new Rot();

            string stringToEncrypt = "Good Bye";
            string expected = "Tbbq Olr";
            string actual = iEncrypt.PerformEncryption(stringToEncrypt);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Decrypt_StringUsingRot_ReturnDecryptedString()
        {
            iEncrypt = new Rot();

            string stringToDecrypt = "Tbbq Olr";
            string expected = "Good Bye";
            string actual = iEncrypt.PerformDecryption(stringToDecrypt);

            Assert.AreEqual(expected, actual);
        }

    }
}
