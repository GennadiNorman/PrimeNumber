using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace PrimeNumberCheckerTests
{
    [TestClass]
    public class PrimeNumberCheckerTests
    {
        [TestMethod]
        public void IsPrime_ReturnsTrueForPrimeNumbers()
        {
            var checker = new PrimeNumberChecker();
            int[] primeNumbers = { 2, 3, 5, 7, 11 };

            foreach (int number in primeNumbers)
            {
                Assert.IsTrue(checker.IsPrime(number));
            }
        }

        [TestMethod]
        public void IsPrime_ReturnsFalseForNonPrimeNumbers()
        {
            var checker = new PrimeNumberChecker();
            int[] nonPrimeNumbers = { 4, 6, 8, 9, 12 };

            foreach (int number in nonPrimeNumbers)
            {
                Assert.IsFalse(checker.IsPrime(number));
            }
        }
    }
}
