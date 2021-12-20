using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int[] array1 = new int[0];
        int[] array2 = { 1, 2, 3, 4 };
        int[] array3 = { 3, 2, 4 };

        [TestMethod]
        public void TestMethod1()
        {
            Assert.ReferenceEquals(array1, Class1.Galustyan(new int[0]));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ReferenceEquals(array2, Class1.Galustyan(new int[] { 1, 2, 1, 4}));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.ReferenceEquals(array3, Class1.Galustyan(new int[] { 1, 2, 4 }));
        }
    }
}
