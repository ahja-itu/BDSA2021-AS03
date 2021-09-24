using System;
using System.Collections.Generic;
using Xunit;


namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [ClassData(typeof(IsSecureData))]
        public void IsSecure_givenCustomDataSet_ShouldHoldForAll(string url, bool expected)
        {
            Assert.Equal(expected, (new Uri(url)).IsSecure());
        }


        [Theory]
        [ClassData(typeof(WordCountData))]
        public void WordCount_givenDataSet_shouldHoldForAll(string words, int expected)
        {
            Assert.Equal(expected, words.WordCount());
        }
    }

    public class WordCountData : TheoryData<string, int>
    {
        public WordCountData()
        {
            Add("Hello, World", 2);
            Add("Hello, my name is Bob", 5);
        }
    }



    public class IsSecureData : TheoryData<string, bool>
    {
        public IsSecureData()
        {
            Add("http://mydomain.com", false);
            Add("https://otherdomain.com", true);
        }
    }
}

