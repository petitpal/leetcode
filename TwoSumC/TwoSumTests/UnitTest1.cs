using NUnit.Framework;

namespace TwoSumTests
{
    public class Tests
    {
        private TwoSumLib.Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new TwoSumLib.Solution();
        }

        [Test]
        public void Test1()
        {
            var thing = _solution.TwoSum(null, 0);
            Assert.Pass();
        }
    }
}