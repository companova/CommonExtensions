using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Companova.Common.Extensions.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void IsNull()
        {
            List<string> nullList = null;
            bool isNull = nullList.IsNullOrEmpty();

            Assert.IsTrue(isNull);
        }

        [TestMethod]
        public void IsEmpty()
        {
            List<int> emptyList = new List<int>();
            bool isEmpty = emptyList.IsNullOrEmpty();

            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void IsNotEmpty()
        {
            List<int> emptyList = new List<int>(3) { 1, 2, 3 };
            bool isEmpty = emptyList.IsNullOrEmpty();

            Assert.IsFalse(isEmpty);
        }
    }
}
