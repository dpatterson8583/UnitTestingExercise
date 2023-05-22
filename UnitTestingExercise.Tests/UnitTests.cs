using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 5, 8)]
        [InlineData(2, 4, 5, 11)]
        [InlineData(3, 5, 5, 13)]
        [InlineData(4, 3, 5, 12)]
        [InlineData(5, 3, -5, 3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // DONE: create a Calculator object
            var calc = new Calculator();

            //Act
            // DONE: call the Add method that is located in the Calculator class
            // DONE:and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//DONE:  Add test data <-------
        [InlineData(20, 5,15)]
        [InlineData(30, 15, 15)]
        [InlineData(40, 20, 20)]
        [InlineData(50, -5, 55)]
        [InlineData(60, 35, 25)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend,subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3,5,15)]//DONE:Add test data <-------
        [InlineData(7, 5, 35)]
        [InlineData(7, 3, 21)]
        [InlineData(12, 11, 132)]
        [InlineData(0, 5, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6,2,3)]//DONE:  Add test data <-------
        [InlineData(16, 8, 2)]
        [InlineData(27, 3, 9)]
        [InlineData(-6, 2, -3)]
        [InlineData(6, -2, -3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
