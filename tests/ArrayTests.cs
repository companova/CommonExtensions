using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Companova.Common.Extensions.Tests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestShuffle()
        {
            int[] arr = new int[100];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            arr.Shuffle();

            //  not sure what/how to validate
        }
    }
}
