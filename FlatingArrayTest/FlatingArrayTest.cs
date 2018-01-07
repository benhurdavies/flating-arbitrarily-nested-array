using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlatingArray;

namespace FlatingArrayTest
{
    [TestClass]
    public class FlatingArrayTest
    {
        [TestMethod]
        public void GivenCase()
        {
            object input = new object[] { new object[] { 1, 2, new int[] { 3 } }, 4 };
            int[] expectedOutput = new int[] {1,2,3,4 };
            int[] output = (new FlatingArray.FlatArray(input)).makeFlating();
            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestComplexObject()
        {
            object input = new object[] { 5, new int[] { 2, 8 }, new object[] { 1, 2, new int[] { 7, 8 } }, 9 };
            int[] expectedOutput = new int[] { 5, 2, 8, 1, 2, 7, 8, 9 };
            int[] output =(new FlatingArray.FlatArray(input)).makeFlating();
            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestEmptyObject()
        {
            object input = new object[] { };
            int[] expectedOutput = new int[] { };
            int[] output = (new FlatingArray.FlatArray(input)).makeFlating();
            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Not an expected object type")]
        public void TestFailedCase()
        {
            object input = new object[] { 5, new int[] { 2, 8 }, new object[] { 1, 2, new int[] { 7, 8 } }, "5" };
            int[] output = (new FlatingArray.FlatArray(input)).makeFlating();
        }
    }
}
