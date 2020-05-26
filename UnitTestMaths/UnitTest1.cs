using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace UnitTestMaths
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Unit test for adding the value
        public void AddTest()
        {
            //Arrange
            BasicMaths addValue = new BasicMaths();
            double expected = 30;
            //Act
            double actual = addValue.Add(20,10);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Unit test for subtracting the value
        [TestMethod]
        public void SubstractTest()
        {
            //Arrange
            BasicMaths sub = new BasicMaths();
            double expected = 10;
            //Act
            double actual = sub.Substract(20, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Unit test for multiply the value
        [TestMethod]
        public void MultiplyTest()
        {
            //Arrange
            BasicMaths mul = new BasicMaths();
            double expected = 200;
            //Act
            double actual = mul.Multiply(20, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Unit test for Dividing the value
        [TestMethod]
        public void DivideTest()
        {
            //Arrange
            BasicMaths div = new BasicMaths();
            double expected = 2;
            //Act
            double actual = div.Divide(20, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
