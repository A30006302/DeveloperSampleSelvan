using Xunit;

// developer selvan seeman
// 02/26/2023
namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact]
        public void CanGetFactorial()
        {
            Assert.Equal(1, Algorithms.GetFactorial(1));
            Assert.Equal(24, Algorithms.GetFactorial(4));
            Assert.Equal(5040, Algorithms.GetFactorial(7));
            Assert.Equal(362880, Algorithms.GetFactorial(9));
        }

        [Fact]
        public void CanFormatSeparators()
        {
            Assert.Equal("a", Algorithms.FormatSeparators("a"));
            Assert.Equal("a and b", Algorithms.FormatSeparators("a", "b"));
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
            Assert.Equal("a, b, c, d and e", Algorithms.FormatSeparators("a", "b", "c", "d", "e"));
        }
    }
}