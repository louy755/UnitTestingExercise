using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, -1, 1, 0)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(100, 1000, 100, 1200)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(0, -1, 1)]
        [InlineData(-10, -10, 0)]
        [InlineData(200, 100, 100)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 0, 0)]
        [InlineData(-20, -10, 200)]
        [InlineData(100, 100, 10000)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(-20, -2, 10)]
        [InlineData(20, 0, -1)]
        [InlineData(200, 20, 10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        //[Fact]
        //public void YourMethodName()
        //{
        //    //Arrange

        //    //Act

        //    //Assert

        //}

        //[Fact]
        //public void YourMethodName2()
        //{
        //    //Arrange
        //    //Act

        //    //Assert
        //}
    }
}
