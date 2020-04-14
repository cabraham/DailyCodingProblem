using DCP.Exercises.Problem_002;
using NUnit.Framework;

namespace DCP.Tests.Problem_002
{
    public class WhenSolving
    {
        private Problem sut;
        private int[] expected;
        [SetUp]
        public void Given()
        {
            var input = new[] { 1, 2, 3, 4, 5 };
            expected = new[] { 120, 60, 40, 30, 24 };

            sut = new Problem(input);
        }

        [Test]
        public void ReturnsExpectedArray()
        {
            var result = sut.Solve();
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
