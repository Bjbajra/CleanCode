using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD.Tests
{ 
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _calculator = new StringCalculator();
        [Test]
        public void StringCalculator_GivenStringIsEmpty_Returns0()
        {  
            //Arrange
            var expectedResult = 0;

            //Act
            var calculatedResult = _calculator.Add("");

            //Assert
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));

        }
        
        [Test]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void StringCalculator_GivenStringWithOneNumber_ReturnsNumber(string numbers, int expectedResult)
        {  
            //Arrange
            
            //Act
            var calculatedResult = _calculator.Add(numbers);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));

        }

        [Test]
        [TestCase("1,2", 3)]
        [TestCase("2,3", 5)]
        public void StringCalculator_GivenStringWithTwoCommaSeperatedNumber_ReturnsSum(string numbers, int expectedResult)
        {
            //Arrange

            //Act
            var calculatedResult = _calculator.Add(numbers);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));

        }

        [Test]
        [TestCase("1,2,3", 6)]
        [TestCase("2,3,4", 9)]
        public void StringCalculator_GivenStringWithThreeCommaSeperatedNumber_ReturnsSum(string numbers, int expectedResult)
        {
            //Arrange

            //Act
            var calculatedResult = _calculator.Add(numbers);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));

        }
    }
}
