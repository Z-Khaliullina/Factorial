using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void factorial_0_1returned()
        {
            uint n = 0;
            ulong expected = 1;

            Class1 obj = new Class1();
            ulong actual = obj.Factorial(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void factorial_10_3628800returned()
        {
            uint n = 10;
            ulong expected = 3628800;

            Class1 obj = new Class1();
            ulong actual = obj.Factorial(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void factorial_20_2432902008176640000returned()
        {
            uint n = 20;
            ulong expected = 2432902008176640000;

            Class1 obj = new Class1();
            ulong actual = obj.Factorial(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
