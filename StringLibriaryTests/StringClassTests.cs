using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLibriary;

namespace StringLibriaryTests
{
    [TestClass]
    public class StringClassTests
    {
        [TestMethod]
        public void Censore_Radish_ReturnAsterisks()
        {
            //Arrange
            string textString = "редиска";
            string exem = "*******";
            //Act
            string actual = StringClass.Censore(textString);
            //Assert
            Assert.AreEqual(actual, exem);
        }

        [TestMethod]
        public void Censore_ThePhraseWithRadish_ReturnAsterisks()
        {
            //Arrange
            string textString = "редиска красная";
            string exem = "******* красная";
            //Act
            string actual = StringClass.Censore(textString);
            //Assert
            Assert.AreEqual(actual, exem);
        }
      
        [TestMethod]
        public void Censore_ThePhraseWithoutRadishes_ReturnAsterisks()
        {
            //Arrange
            string textString = "укроп и петрушка зеленые";
            string exem = "укроп и петрушка зеленые";
            //Act
            string actual = StringClass.Censore(textString);
            //Assert
            Assert.AreEqual(actual, exem);
        }

        [TestMethod]
        public void Censore_ThePhraseWithRadish1_ReturnAsterisks()
        {
            //Arrange
            string textString = "РЕДИСКА красная";
            string exem = "******* красная";
            //Act
            string actual = StringClass.Censore(textString);
            //Assert
            Assert.AreEqual(actual, exem);
        }

        [TestMethod]
        public void Censore_ThePhraseWithRadish2_ReturnAsterisks()
        {
            //Arrange
            string textString = "РеДиСкА красная";
            string exem = "******* красная";
            //Act
            string actual = StringClass.Censore(textString);
            //Assert
            Assert.AreEqual(actual, exem);
        }
    }
}
