using NUnit.Framework;

namespace InterleavingStringTest
{
    public class Tests
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            // arrange
            var s1 = "aabcc";
            var s2 = "dbbca";
            var s3 = "aadbbcbcac";

            // act
            var result = _solution.IsInterleave(s1, s2, s3);

            // assert
            Assert.IsTrue(result);
        }


        [Test]
        public void Test2()
        {
            // arrange
            var s1 = "aabcc";
            var s2 = "dbbca";
            var s3 = "aadbbbaccc";

            // act
            var result = _solution.IsInterleave(s1, s2, s3);

            // assert
            Assert.IsFalse(result);
        }


        [Test]
        public void Test3()
        {
            // arrange
            var s1 = "";
            var s2 = "";
            var s3 = "";

            // act
            var result = _solution.IsInterleave(s1, s2, s3);

            // assert
            Assert.IsTrue(result);
        }
    }
}