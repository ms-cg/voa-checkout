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
            // Apples
            System.Console.WriteLine("One Apple: " + VoaCheckout.GetTotalPrice(new String[] { A }));
            System.Console.WriteLine("Two Apples: " + VoaCheckout.GetTotalPrice(new String[] { A, A }));
            System.Console.WriteLine("Three Apples: " + VoaCheckout.GetTotalPrice(new String[] { A, A, A }));
            System.Console.WriteLine("Four Apples: " + VoaCheckout.GetTotalPrice(new String[] { A, A, A, A }));
            // Oranges
            System.Console.WriteLine("One Orange: " + VoaCheckout.GetTotalPrice(new String[] { O }));
            System.Console.WriteLine("Two Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O }));
            System.Console.WriteLine("Three Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O, O }));
            System.Console.WriteLine("Four Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O, O, O }));
            System.Console.WriteLine("Five Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O, O, O, O }));
            System.Console.WriteLine("Six Oranges: " + VoaCheckout.GetTotalPrice(new String[] { O, O, O, O, O, O }));
            // Apples and Oranges
            System.Console.WriteLine("One Apple, one Orange: " + VoaCheckout.GetTotalPrice(new String[] { A, O }));
            System.Console.WriteLine("Two Apples, Two Oranges: " + VoaCheckout.GetTotalPrice(new String[] { A, O, A, O }));
            System.Console.WriteLine("Three Apple, Three Orange: " + VoaCheckout.GetTotalPrice(new String[] { A, O, A, O, A, O }));
        }
    }
}
