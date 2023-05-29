﻿using ActionAndFunc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ActionAndFuncDelegateTests
{
    [TestClass]
    public class UnitTest
    {
        [TestClass]
        public class ExampleTests
        {
            [TestMethod]
            public void WhenPrintNumbersWithoutAction_ThenNumbersPrintedCorrectly()
            {
                // Arrange
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var stringWriter = new StringWriter();
                Console.SetOut(stringWriter);
                var expectedOutput = "1\r\n2\r\n3\r\n4\r\n5"; // Remove the trailing \r\n

                // Act
                Example.PrintNumbersWithoutAction(numbers);
                var actualOutput = stringWriter.ToString().TrimEnd(); // Trim trailing white space

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }

            [TestMethod]
            public void WhenPrintNumbersWithAction_ThenNumbersPrintedCorrectly()
            {
                // Arrange
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                var stringWriter = new StringWriter();
                Console.SetOut(stringWriter);
                var expectedOutput = "1\r\n2\r\n3\r\n4\r\n5"; // Remove the trailing \r\n

                // Act
                Action<int> printNumber = Console.WriteLine;
                Example.PrintNumbersWithAction(numbers, printNumber);
                var actualOutput = stringWriter.ToString().TrimEnd(); // Trim trailing white space

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }

        }
    }
}