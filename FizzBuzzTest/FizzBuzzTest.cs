using System;
using System.Collections.ObjectModel;
using System.Xml.Xsl;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest : Attributes
    {
        private FizzBuzzFunction _function;
        private NumberThree _numberThree;
        private NumberFive _numberFive;

        public FizzBuzzTest()
        {
            _function = new FizzBuzzFunction();
            _numberThree = new NumberThree();
            _numberFive = new NumberFive();
        }

        [Fact]
        public void Print_Number_from_1_to_100()
        {
            _function.Print_Number_from_1_to_100(ONE, NUMBER_FINAL);
        }

        [Theory]
        [InlineData(3)]
        public void Print_Fizz_Multiple_3(int request)
        {
            Collection<string> expected = _numberThree.GetCollectionMultipleThree(request);
            Collection<string> result = _function.Print_Fizz_Multiple_3(request);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5)]
        public void Print_Buzz_Multiple_5(int request)
        {
            Collection<string> expected = _numberFive.GetCollectionMultipleFive(request);
            Collection<string> result = _function.Print_Buzz_Multiple_5(request);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 5, new string[] {"1","2","3","4","5","6","7","8","9","10","11","12","13","14","FIZZBUZZ",
            "16","17","18","19","20","21","22","23","24","25","26","27","28","29","FIZZBUZZ","31","32","33","34",
            "35","36","37","38","39","40","41","42","43","44","FIZZBUZZ","46","47","48","49","50","51","52","53",
            "54","55","56","57","58","59","FIZZBUZZ","61","62","63","64","65","66","67","68","69","70","71","72",
            "73","74","FIZZBUZZ","76","77","78","79","80","81","82","83","84","85","86","87","88","89","FIZZBUZZ",
            "91","92","93","94","95","96","97","98","99","100"})]
        public void Print_FizzBuzz_Multiple_3_and_5(int requestOne, int requestTwo, string[] expected)
        {
            Collection<string> result = _function.Print_FizzBuzz();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 5, new string[] {"1","2","FIZZ","4","BUZZ","FIZZ","7","8","FIZZ","BUZZ","11","FIZZ",
            "13","14","FIZZBUZZ","16","17","FIZZ","19","BUZZ","FIZZ","22","23","FIZZ","BUZZ","26","FIZZ",
            "28","29","FIZZBUZZ","31","32","FIZZ","34","BUZZ","FIZZ","37","38","FIZZ","BUZZ","41","FIZZ",
            "43","44","FIZZBUZZ","46","47","FIZZ","49","BUZZ","FIZZ","52","53","FIZZ","BUZZ","56","FIZZ",
            "58","59","FIZZBUZZ","61","62","FIZZ","64","BUZZ","FIZZ","67","68","FIZZ","BUZZ","71","FIZZ",
            "73","74","FIZZBUZZ","76","77","FIZZ","79","BUZZ","FIZZ","82","83","FIZZ","BUZZ","86","FIZZ",
            "88","89","FIZZBUZZ","91","92","FIZZ","94","BUZZ","FIZZ","97","98","FIZZ","BUZZ"})]
        public void Print_Everything(int requestOne, int requestTwo, string[] expected)
        {
            Collection<string> result = _function.Print_Everything(requestOne, requestTwo, expected);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(45, true)]
        [InlineData(113, false)]
        [InlineData(-23, false)]
        [InlineData(11, true)]
        [InlineData(0, false)]
        public void IsExist_Number_From_1_To_100(int request, bool expected)
        {
            bool result = _function.VerifyNumberFrom1To100(request);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(9, "FIZZ")]
        [InlineData(5, "BUZZ")]
        [InlineData(30, "FIZZBUZZ")]
        [InlineData(88, "88")]
        public void Get_Result_Numbers_Criterial(int request, string expected)
        {
            string result = _function.GetResultNumbersCriterial(request);
            Assert.Equal(expected, result);
        }
        
    }
}