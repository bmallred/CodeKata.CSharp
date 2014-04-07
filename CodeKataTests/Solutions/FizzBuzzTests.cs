using System.Collections.Generic;
using CodeKata.Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests.Solutions
{
    /// <summary>
    /// FizzBuzz test cases.
    /// </summary>
    [TestClass]
    public class FizzBuzzTests
    {
        /// <summary>
        /// The expected output.
        /// </summary>
        private static IDictionary<int, string> output = new Dictionary<int, string>()
        {
            { 1, "1" }, { 2, "2" }, { 3, "fizz" }, { 4, "4" }, { 5, "buzz" }, { 6, "fizz" }, { 7, "7" }, { 8, "8" }, { 9, "fizz" },
            { 10, "buzz" }, { 11, "11" }, { 12, "fizz" }, { 13, "13" }, { 14, "14" }, { 15, "fizzbuzz" }, { 16, "16" }, { 17, "17" }, { 18, "fizz" }, { 19, "19" },
            { 20, "buzz" }, { 21, "fizz" }, { 22, "22" }, { 23, "23" }, { 24, "fizz" }, { 25, "buzz" }, { 26, "26" }, { 27, "fizz" }, { 28, "28" }, { 29, "29" },
            { 30, "fizzbuzz" }, { 31, "31" }, { 32, "32" }, { 33, "fizz" }, { 34, "34" }, { 35, "buzz" }, { 36, "fizz" }, { 37, "37" }, { 38, "38" }, { 39, "fizz" },
            { 40, "buzz" }, { 41, "41" }, { 42, "fizz" }, { 43, "43" }, { 44, "44" }, { 45, "fizzbuzz" }, { 46, "46" }, { 47, "47" }, { 48, "fizz" }, { 49, "49" },
            { 50, "buzz" }, { 51, "fizz" }, { 52, "52" }, { 53, "53" }, { 54, "fizz" }, { 55, "buzz" }, { 56, "56" }, { 57, "fizz" }, { 58, "58" }, { 59, "59" },
            { 60, "fizzbuzz" }, { 61, "61" }, { 62, "62" }, { 63, "fizz" }, { 64, "64" }, { 65, "buzz" }, { 66, "fizz" }, { 67, "67" }, { 68, "68" }, { 69, "fizz" },
            { 70, "buzz" }, { 71, "71" }, { 72, "fizz" }, { 73, "73" }, { 74, "74" }, { 75, "fizzbuzz" }, { 76, "76" }, { 77, "77" }, { 78, "fizz" }, { 79, "79" },
            { 80, "buzz" }, { 81, "fizz" }, { 82, "82" }, { 83, "83" }, { 84, "fizz" }, { 85, "buzz" }, { 86, "86" }, { 87, "fizz" }, { 88, "88" }, { 89, "89" },
            { 90, "fizzbuzz" }, { 91, "91" }, { 92, "92" }, { 93, "fizz" }, { 94, "94" }, { 95, "buzz" }, { 96, "fizz" }, { 97, "97" }, { 98, "98" }, { 99, "fizz" },
            { 100, "buzz" }
        };

        /// <summary>
        /// Determines whether this instance [can return default value].
        /// </summary>
        [TestMethod]
        public void CanReturnDefaultValue()
        {
            Assert.AreEqual(output[1], FizzBuzz.Run(1));
        }

        /// <summary>
        /// Determines whether this instance [can return fizz].
        /// </summary>
        [TestMethod]
        public void CanReturnFizz()
        {
            Assert.AreEqual(output[3], FizzBuzz.Run(3));
        }

        /// <summary>
        /// Determines whether this instance [can return buzz].
        /// </summary>
        [TestMethod]
        public void CanReturnBuzz()
        {
            Assert.AreEqual(output[5], FizzBuzz.Run(5));
        }

        /// <summary>
        /// Determines whether this instance [can return fizz buzz].
        /// </summary>
        [TestMethod]
        public void CanReturnFizzBuzz()
        {
            Assert.AreEqual(output[15], FizzBuzz.Run(15));
        }

        /// <summary>
        /// Propers the output from range.
        /// </summary>
        [TestMethod]
        public void ProperOutputFromRange()
        {
            foreach (var key in output.Keys)
            {
                Assert.AreEqual(output[key], FizzBuzz.Run(key));
            }
        }
    }
}