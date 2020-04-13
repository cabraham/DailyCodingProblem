using DCP.Exercises.Problem_001;
using NUnit.Framework;

namespace DCP.Tests
{
    public class WhenArrayHasNumbersThatAddUpToK
    {
        private Problem problem;
        private const int K = 17;

        [SetUp]
        public void Setup()
        {
            var input = new[] { 10, 15, 3, 7 };
            problem = new Problem(input);
        }

        [Test]
        public void ReturnsTrue()
        {
            Assert.IsTrue(problem.Solve(K));
        }
    }

    public class WhenArrayDoesNotHasNumbersThatAddUpToK
    {
        private Problem problem;
        private const int K = 14;

        [SetUp]
        public void Setup()
        {
            var input = new[] { 10, 15, 3, 7 };
            problem = new Problem(input);
        }

        [Test]
        public void ReturnsFalse()
        {
            Assert.IsFalse(problem.Solve(K));
        }
    }

}