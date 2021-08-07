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
            TestRunner(
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1 }
            );
        }

        [Test]
        public void Test2()
        {
            TestRunner(
                new int[] { 3, 2, 4 },
                6,
                new int[] { 1, 2 }
            );
        }

        [Test]
        public void Test3()
        {
            TestRunner(
                new int[] { 3, 3 },
                6,
                new int[] { 0, 1 }
            );
        }

        public void TestRunner(int[] input, int target, int[] expected)
        {
            // arrange
            
            // act
            var output = _solution.TwoSum(input, target);

            // assert
            Assert.AreEqual(expected[0], output[0]);
            Assert.AreEqual(expected[1], output[1]);
        }
        
    }
}