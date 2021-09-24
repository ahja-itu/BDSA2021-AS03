using System;
using System.Text;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{


    delegate string MyReverse(string input);

    public class DelegatesTests
    {
        [Fact]
        public void Exercise1()
        {
            // Doing this the "old fashioned, imperative way"
            var myReverse = new MyReverse ((input) => {
                var b = new StringBuilder();
                for(int i = input.Length - 1; i >= 0; i--)
                    b.Append(input[i]);
                return b.ToString();
            });

            string input = "andreas";

            string expected = "saerdna";

            Assert.Equal(expected, myReverse(input));
        }

        [Fact]
        public void Exercise2()
        {
            var mult = new Func<double, double, double>((a, b) => a*b);

            double a = 2.0, b = 3.5;

            double result = mult(a, b);

            Assert.Equal(7.0, result);
        }

        [Fact]
        public void Exercise3()
        {
            var myparse = new Func<int, string, bool>((num, text) => {
                int parsedNum;
                if (Int32.TryParse(text, out parsedNum)) {
                    return num == parsedNum;
                } 

                return false;
            });
            Assert.True(myparse(42, "  0042"));
        }

    }
}
