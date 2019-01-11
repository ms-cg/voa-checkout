using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoaCheckout
{
    /// <summary>
    /// Simple demonstration console application that exercises the VoaCheckout.GetTotalPrice() method.
    /// </summary>
    class VoaCheckoutApp
    {
        private const String A = "Apple";
        private const String O = "Orange";

        static void Main(string[] args)
        {
            System.Console.WriteLine("(All prices in pence)");
            System.Console.WriteLine("One Apple: " + VoaCheckout.GetTotalPrice(new String[] { A }));
            System.Console.WriteLine("Two Apples: " + VoaCheckout.GetTotalPrice(new String[] { A, A }));
            System.Console.WriteLine("One Orange: " + VoaCheckout.GetTotalPrice(new String[] { O }));
            System.Console.WriteLine("Two Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O }));
            System.Console.WriteLine("One Apple, one Orange: " + VoaCheckout.GetTotalPrice(new String[] { A, O }));
        }
    }
}
