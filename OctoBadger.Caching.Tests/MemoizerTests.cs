using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OctoBadger.Caching.Tests
{
    [TestClass]
    public class MemoizerTests
    {
        [TestMethod]
        public void MyFirstMemoizer()
        {
            Func<string> hook = () =>
            {
                return "result";
            };

            Func<string> memo = Memoizer.Create(hook);

            Assert.AreEqual(memo(), "result");
        }
    }
}
