using FizzBuzz.Library;
using Moq;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace UnitTests.FizzBuzz.Library
{
    [TestFixture]
    public class FizzBuzzOutputterTest
    {
        [Test]
        public void GetFizzBuzzOutputWithPairs3Fizz5BuzzAndUpperBound15ShouldReturnCorrectOutput()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>()
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz",
                "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            };
            var pairs = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(5, "Buzz"),
            };
            int upperBound = 15;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }

        [Test]
        public void GetFizzBuzzOutputWithPairsNullAndUpperBound15ShouldReturnCorrectResult()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>()
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "10", "11", "12", "13", "14", "15"
            };
            List<KeyValuePair<int, string>> pairs = null;
            int upperBound = 15;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }

        [Test]
        public void GetFizzBuzzOutputWithPairsEmptyAndUpperBound15ShouldReturnCorrectResult()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>()
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "10", "11", "12", "13", "14", "15"
            };
            var pairs = new List<KeyValuePair<int, string>>();
            int upperBound = 15;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }

        [Test]
        public void GetFizzBuzzOutputWithUpperBound1ShouldReturnCorrectOutput()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>()
            {
                "1"
            };
            var pairs = It.IsAny<List<KeyValuePair<int, string>>>();
            int upperBound = 1;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }

        [Test]
        public void GetFizzBuzzOutputWithUpperBound0ShouldReturnEmptyList()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>();
            var pairs = It.IsAny<List<KeyValuePair<int, string>>>();
            int upperBound = 0;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }

        [Test]
        public void GetFizzBuzzOutputWithUpperBoundNegativeNumberShouldReturnEmptyList()
        {
            var objectUnderTest = new FizzBuzzOutput();
            var expected = new List<string>();
            var pairs = It.IsAny<List<KeyValuePair<int, string>>>();
            int upperBound = -1;

            var result = objectUnderTest.GetFizzBuzzOutput(pairs, upperBound);

            result.ShouldBe(expected);
        }
    }
}
