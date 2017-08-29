using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeString
{
    [TestClass]
    public class PrimeStringTests
    {
        
        [TestMethod]
        public void abac_Should_Be_Pass()
        {
            AssertShouldBePrimeString("abac");
        }

        [TestMethod]
        public void abab_Should_Be_Fail()
        {
            AssertShouldNotBePrimeString("abab");
        }

        [TestMethod]
        public void aaaa_Should_Be_Fail()
        {
            AssertShouldNotBePrimeString("aaaa");
        }

        [TestMethod]
        public void x_Should_Be_Pass()
        {
            AssertShouldBePrimeString("x");
        }

        [TestMethod]
        public void fdsyffdsyffdsyffdsyffdsyf_Should_Be_Fail()
        {
            AssertShouldNotBePrimeString("aaaa");
        }

        [TestMethod]
        public void utdutdtdutd_Should_Be_Pass()
        {
            AssertShouldBePrimeString("abc");
        }

        [TestMethod]
        public void abba_Should_Be_Pass()
        {
            AssertShouldBePrimeString("abc");
        }

        [TestMethod]
        public void ab_Should_Be_Pass()
        {
            AssertShouldBePrimeString("abc");
        }
        private static void AssertShouldNotBePrimeString(string s)
        {
            var kata = new Kata();
            Assert.IsFalse(kata.IsPrimeString(s));
        }

        private static void AssertShouldBePrimeString(string s)
        {
            var kata = new Kata();
            Assert.IsTrue(kata.IsPrimeString(s));
        }

    }

    public class Kata
    {
        public bool IsPrimeString(string inputString)
        {

            for (int i = 1; i <= inputString.Length / 2; i++)
            {
                if (inputString.Split(new[] { inputString.Substring(0, i) }, StringSplitOptions.RemoveEmptyEntries)
                        .LongCount(x => x.Length > 0) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}