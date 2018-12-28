using System;
using NUnit.Framework;
using LabExam;

namespace Tests
{
    [TestFixture]
    public class StringConverterTests
    {
        [Test]
        public void Convert_WrongTest_NUnit()
        {
            StringConverter stringConverter = new StringConverter();

            Assert.Throws<ArgumentNullException>(() => stringConverter.Convert(null, 2));
        }

        [Test]
        public void Convert_WrongTestEmptyString_NUnit()
        {
            StringConverter stringConverter = new StringConverter();

            Assert.Throws<ArgumentNullException>(() => stringConverter.Convert(string.Empty, 1));
        }

        [Test]
        public void Convert_WrongTestNnull_NUnit()
        {
            StringConverter stringConverter = new StringConverter();

            string s = "Привет Епам!";

            Assert.Throws<ArgumentOutOfRangeException>(() => stringConverter.Convert(s, 0));
        }

        [Test]
        [TestCase("Привет Епам!", 1, ExpectedResult = "Пие пмрвтЕа!")]        
        public string Convert_InputCorrect1_Nunit(string s, int n)
        {
            StringConverter stringConverter = new StringConverter();

            return stringConverter.Convert(s, n);
        }

        [Test]
        [TestCase("Пие пмрвтЕа!", 1, ExpectedResult = "Пепртаи мвЕ!")]
        public string Convert_InputCorrect2_Nunit(string s, int n)
        {
            StringConverter stringConverter = new StringConverter();

            return stringConverter.Convert(s, n);
        }
    }
}
