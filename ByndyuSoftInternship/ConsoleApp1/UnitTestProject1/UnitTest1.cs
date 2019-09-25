using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ByndyuSoftTests
{
    [TestClass]
    public class SumOfMinsTest
    {

        [TestMethod]
        public void SumOfMins_TestConsistency()
        {
            //arrange
            int[] tarr = { 4, 0, 3, 19, 492, -10, 1 };
            int expectedSum = -10;

            //act
            int actual = Byndyusoft.GetSumOfMins(ref tarr);

            //assert
            Assert.AreEqual(expectedSum, actual);
        }
        [TestMethod]
        public void SumOfMins_TestNull()
        {
            int[] arr = null;
            Assert.ThrowsException<ArgumentException>(() => Byndyusoft.GetSumOfMins(ref arr));
        }
        [TestMethod]
        public void SumOfMins_TestIntOverflow()
        {
            //arrange
            int[] tarr = {2147483647, 99999 };
            Assert.ThrowsException<System.OverflowException>(() => Byndyusoft.GetSumOfMins(ref tarr));
        }
    }
}
