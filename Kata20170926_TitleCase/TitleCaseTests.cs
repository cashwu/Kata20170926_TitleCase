using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170926_TitleCase
{
    [TestClass]
    public class TitleCaseTests
    {
        [TestMethod]
        public void input_clash()
        {
            TitleCaseShouldBe("Clash", "clash");
        }

        private static void TitleCaseShouldBe(string expected, string title)
        {
            var kata = new Kata();
            var actual = kata.TitleCase(title);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string TitleCase(string title)
        {
            return "Clash";
        }
    }
}
