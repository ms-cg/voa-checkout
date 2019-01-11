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
        private const String A = "Apple";
        private const String O = "Orange";

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

        // ////////////////////////////////////////////
        // Only Apples
        // ////////////////////////////////////////////

        [TestMethod]
        public void OneAppleIs60p()
        {
            // Arrange
            String[] items = { A };
            int expectation = 60;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void TwoApplesAre60p()
        {
            // Arrange
            String[] items = { A, A };
            int expectation = 60;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void ThreeApplesAre120p()
        {
            // Arrange
            String[] items = { A, A, A };
            int expectation = 120;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void FourApplesAre120p()
        {
            // Arrange
            String[] items = { A, A, A, A };
            int expectation = 120;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        // ////////////////////////////////////////////
        // Only Oranges
        // ////////////////////////////////////////////

        [TestMethod]
        public void OneOrangeIs25p()
        {
            // Arrange
            String[] items = { O };
            int expectation = 25;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void TwoOrangesAre50p()
        {
            // Arrange
            String[] items = { O, O };
            int expectation = 50;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void ThreeOrangesAre50p()
        {
            // Arrange
            String[] items = { O, O, O };
            int expectation = 50;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void FourOrangesAre75p()
        {
            // Arrange
            String[] items = { O, O, O, O };
            int expectation = 75;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void FiveOrangesAre100p()
        {
            // Arrange
            String[] items = { O, O, O, O, O };
            int expectation = 100;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void SixOrangesAre100p()
        {
            // Arrange
            String[] items = { O, O, O, O, O, O };
            int expectation = 100;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        // ////////////////////////////////////////////
        // Mix of Apples and Oranges
        // ////////////////////////////////////////////

        [TestMethod]
        public void OneAppleAndOneOrangeIs85p()
        {
            // Arrange
            String[] items = { A, O };
            int expectation = 85;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void TwoApplesAndTwoOrangesIs110p()
        {
            // Arrange
            String[] items = { A, O, A, O };   // (In mixed order)
            int expectation = 110;

            // Act, Assert
            CommonActAssert(items, expectation);
        }

        [TestMethod]
        public void ThreeApplesAndThreeOrangesIs170p()
        {
            // Arrange
            String[] items = { A, O, A, O, A, O };   // (In mixed order)
            int expectation = 170;

            // Act, Assert
            CommonActAssert(items, expectation);
        }
    }
}
