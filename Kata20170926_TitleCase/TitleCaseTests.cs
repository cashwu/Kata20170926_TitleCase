using System;
using System.Linq;
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

        [TestMethod]
        public void input_clash_of()
        {
            TitleCaseShouldBe("Clash Of", "clash of");
        }

        [TestMethod]
        public void input_clash_of_KINGS()
        {
            TitleCaseShouldBe("Clash Of Kings", "clash of KINGS");
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
            return string.Join(" ", title.Split(' ').Select(FirstCharToUpper));
        }

        private string FirstCharToUpper(string str)
        {
            return $"{char.ToUpper(str[0])}{str.Substring(1).ToLower()}";
        }
    }
}
