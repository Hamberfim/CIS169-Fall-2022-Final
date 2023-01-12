using FinalHamlin.Models;
using System;
using Xunit;

namespace TestFinalHamlin
{
    public class UnitTest1
    {
        //Test 1. Invalid hours worked (too low)
        [Fact]
        public void TestInvalidHoursTooLow()
        {
            // Arrange
            var studentWorkerModel = new StudentWorkerModel();
            studentWorkerModel.Hours = 0.9m;
            decimal expected = 0m;
            decimal? actual;
            // Act
            actual = studentWorkerModel.Hours;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Test 2. Invalid hours worked (too high)
        [Fact]
        public void TestInvalidHoursTooHigh()
        {
            // Arrange
            var studentWorkerModel = new StudentWorkerModel();
            studentWorkerModel.Hours = 15.01m;
            decimal expected = 0m;
            decimal? actual;
            // Act
            actual = studentWorkerModel.Hours;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Test 3. Invalid hourly salary (too low)
        [Fact]
        public void TestInvalidSalaryTooLow()
        {
            // Arrange
            var studentWorkerModel = new StudentWorkerModel();
            studentWorkerModel.Pay = 7.24m;
            decimal expected = 0m;
            decimal? actual;
            // Act
            actual = studentWorkerModel.Pay;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Test 4. Invalid hourly salary (too high)
        [Fact]
        public void TestInvalidSalaryTooHigh()
        {
            // Arrange
            var studentWorkerModel = new StudentWorkerModel();
            studentWorkerModel.Pay = 14.76m;
            decimal expected = 0m;
            decimal? actual;
            // Act
            actual = studentWorkerModel.Pay;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Test 5. Valid test 
        [Fact]
        public void TestValidWeeklySalary()
        {
            // Arrange
            var studentWorkerModel = new StudentWorkerModel();
            studentWorkerModel.Pay = 7.25m;
            studentWorkerModel.Hours = 3.0m;
            decimal expected = 21.75m;
            decimal actual;

            // Act
            actual = studentWorkerModel.WeeklySalary();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
