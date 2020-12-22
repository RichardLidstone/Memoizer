using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OctoBadger.Caching.Tests
{
    [TestClass]
    public class MemoizerTests
    {
        [TestMethod]
        public void BasicZeroParameterMemoization()
        {
            Func<string> hook = () =>
            {
                return "result";
            };

            Func<string> memo = Memoizer.Create(hook);

            Assert.AreEqual(memo(), "result");
        }


        [TestMethod]
        public void BasicSingleParameterMemoization()
        {
            Func<string, string> hook = (input) =>
            {
                return "result";
            };

            Func<string, string> memo = Memoizer.Create(hook);

            Assert.AreEqual(memo("blah"), "result");
        }
    }
}
