using System;
using Xunit;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            bool actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);

        }


    }
}
