﻿using System;
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

        [TestMethod]
        public void input_a_clash_of_KINGS_and_a_of()
        {
            TitleCaseShouldBe("A Clash of Kings", "a clash of KINGS", "a Of");
        }

        [TestMethod]
        public void input_a_clash_of_KINGS_and_a_an_the_of()
        {
            TitleCaseShouldBe("A Clash of Kings", "a clash of KINGS", "a an the of");
        }

        [TestMethod]
        public void input_THE_WIND_IN_THE_WILLOWS_and_The_In()
        {
            TitleCaseShouldBe("The Wind in the Willows", "THE WIND IN THE WILLOWS", "The In");
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
            return string.Join(" ", title.Split(' ').Select((str, i) => TitleCase(str, minorWords, i == 0)));
        }

        private string TitleCase(string str, string minorWords, bool isFirstWord)
        {
            if (isFirstWord)
            {
                return FirstCharToUpperString(str);
            }

            return minorWords.ToLower().Split(' ').Contains(str.ToLower()) 
                ? ToLowerString(str) 
                : FirstCharToUpperString(str);
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
