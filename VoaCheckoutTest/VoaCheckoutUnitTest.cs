using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VoaCheckoutTest
{
    /// <summary>
    /// Unit tests for the VoaCheckout class; just one public method GetTotalPrice().
    /// </summary>
    [TestClass]
    public class VoaCheckoutUnitTest
    {
        /// <summary>
        /// Perform the 'act' and 'assert' processes common to all unit tests in this class.
        /// </summary>
        /// <param name="items">The items to pass as the input parameter to the GetTotalPrice() method.</param>
        /// <param name="expectation">The expected result.</param>
        public void CommonActAssert(String[] items, int expectation)
        {
            // Act
            int totalPrice = VoaCheckout.VoaCheckout.GetTotalPrice(items);

            // Assert
            Assert.AreEqual(expectation, totalPrice);
        }

        [TestMethod]
        public void OneAppleIs60p()
        {
            // Arrange
            String[] items = { "Apple" };
            int expectation = 60;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void TwoApplesAre120p()
        {
            // Arrange
            String[] items = { "Apple", "Apple" };
            int expectation = 120;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void OneOrangeIs25p()
        {
            // Arrange
            String[] items = { "Orange" };
            int expectation = 25;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void TwoOrangesAre50p()
        {
            // Arrange
            String[] items = { "Orange", "Orange" };
            int expectation = 50;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void OneAppleAndOneOrangeIs85p()
        {
            // Arrange
            String[] items = { "Apple", "Orange" };
            int expectation = 85;

            // Act, Assert
            CommonActAssert(items, expectation);
        }
    }
}
