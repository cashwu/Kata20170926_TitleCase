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

        [TestMethod]
        public void input_clash_of_KINGS_and_of()
        {
            TitleCaseShouldBe("Clash of Kings", "clash of KINGS", "of");
        }

        [TestMethod]
        public void input_clash_of_KINGS_and_Of()
        {
            TitleCaseShouldBe("Clash of Kings", "clash of KINGS", "Of");
        }

        private static void TitleCaseShouldBe(string expected, string title, string minorWords = "")
        {
            var kata = new Kata();
            var actual = kata.TitleCase(title, minorWords);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string TitleCase(string title, string minorWords = "")
        {
            var minorWordArray = minorWords.ToLower().Split(' ');

            return string.Join(" ", title.Split(' ').Select(a => TitleCase(a, minorWordArray)));
        }

        private string TitleCase(string word, string[] minorWordArray)
        {
            return minorWordArray.Contains(word.ToLower()) ? ToLowerString(word) : FirstCharToUpperString(word);
        }

        private string ToLowerString(string str)
        {
            return str.ToLower();
        }

        private string FirstCharToUpperString(string str)
        {
            return $"{char.ToUpper(str[0])}{str.Substring(1).ToLower()}";
        }
    }
}
