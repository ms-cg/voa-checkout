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
        /// </summary>
        /// <param name="items">Arrary of items represented as Strings.
        /// Permitted values are "Apple" and "Orange"; any other item is simply ignored.
        /// </param>
        /// <returns>Total price of the items, in pence.</returns>
        public static int GetTotalPrice(String[] items)
        {
            int total = 0;

            // Walk through the items
            foreach (string currItem in items)
            {
                // Add appropriate price to total, according to type of item
                switch (currItem)
                {
                    case "Apple":
                        total += APPLE_PRICE;
                        break;
                    case "Orange":
                        total += ORANGE_PRICE;
                        break;
                    // default: Ignore any other type of item
                }
            }

            return total;
        }
    }
}
