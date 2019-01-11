using System;

namespace VoaCheckout
{
    /// <summary>
    /// Simple 'checkout' class for calculating the total combined price of items.
    /// </summary>
    public class VoaCheckout
    {
        private const int APPLE_PRICE = 60;
        private const int ORANGE_PRICE = 25;

        /// <summary>
        /// Calucate the combined total price of the given items.
        /// Note: applies the following discounts:
        ///  - Apples: Buy-one-get-one-free
        ///  - Oranges: Buy-two-get-one-free
        /// </summary>
        /// <param name="items">Arrary of items represented as Strings.
        /// Permitted values are "Apple" and "Orange"; any other item is simply ignored.
        /// </param>
        /// <returns>Total price of the items, in pence.</returns>
        public static int GetTotalPrice(String[] items)
        {
            int appleCount = 0;
            int orangeCount = 0;

            // Walk through the items and count each type
            foreach (string currItem in items)
            {
                switch (currItem)
                {
                    case "Apple":
                        appleCount++;
                        break;
                    case "Orange":
                        orangeCount++;
                        break;
                    // default: Ignore any other type of item
                }
            }

            // Calc and return the total price
            return GetXForYAdjustedTotal(2, 1, appleCount, APPLE_PRICE) + GetXForYAdjustedTotal(3, 2, orangeCount, ORANGE_PRICE);
        }

        /// <summary>
        /// Generic 'X-for-the-price-of-Y' calcuator.
        /// (E.g. 3-for-2, 2-for-1)
        /// </summary>
        private static int GetXForYAdjustedTotal(int x, int y, int itemCount, int unitPrice)
        {
            int total = 0;
            int nonDiscounted = itemCount % x;

            // One or more 'extra' items not included in a X-for-Y discount grouping
            if (nonDiscounted > 0)
            {
                // Add price of the 'extras' on to the total
                total = nonDiscounted * unitPrice;
                // ...and remove from the item count
                itemCount -= nonDiscounted;
            }

            // Some items remaining (discounted groups)
            if (itemCount > 0)
            {
                // Remaining total is Y/X fraction of the grand total (having already removed the 'extras')
                total += (int)((itemCount * unitPrice) * ((float)y / x));
            }

            return total;
        }
    }
}
