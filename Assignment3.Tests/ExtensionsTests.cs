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
        
    }




    /* 
    

    Test data class
    
    */


    public class IsSecureData : TheoryData<string, bool>
    {
        public IsSecureData()
        {
            Add("http://mydomain.com", false);
            Add("https://otherdomain.com", true);
        }
    }
}

