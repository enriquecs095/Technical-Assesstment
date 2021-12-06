using System;
using Xunit;

namespace Assesstment.Tests
{
    public class UnitTest1
    {

        // Given the user input is empty when calculating the sum then it should return zero.
        [Fact]
        public void Input_is_Empty()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 0;

            // Act
            var result = calc.Sum();
            // Assert

            Assert.Equal(expect, result);
        }


        // Given the user input is one number when calculating the sum then it should return the same number. (example "3" should equal 3)

        [Fact]
        public void Input_is_One_Number_Should_Return_Same_Number()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 3;

            // Act
            var result = calc.Sum("3");
            // Assert

            Assert.Equal(expect, result);
        }

        // Given the user input is two numbers when calculating the sum then it should return the sum of those numbers. (example "1,2" should equal 3)

        [Fact]
        public void Input_is_Two_Numbers_Should_Return_Sum_Of_Them()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 3;

            // Act
            var result = calc.Sum("1,2");
            // Assert

            Assert.Equal(expect, result);
        }

        // Given the user input is an unknown amount of numbers when calculating the sum then it should return the sum of all the numbers. (example "1,2,3" should equal 6)
        [Fact]
        public void Input_is_Unknown_Amount_Of_Numbers_Should_Return_Sum_Of_Them()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 6;

            // Act
            var result = calc.Sum("1,2,3");
            // Assert

            Assert.Equal(expect, result);
        }
    }
}
