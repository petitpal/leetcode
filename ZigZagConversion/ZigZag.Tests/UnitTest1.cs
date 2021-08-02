using NUnit.Framework;

namespace ZigZag.Tests
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
            var result = _solution.Convert("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);
        }

        [Test]
        public void Test2()
        {
            var result = _solution.Convert("PAYPALISHIRING", 4);
            Assert.AreEqual("PINALSIGYAHRPI", result);
        }

        [Test]
        public void Test3()
        {
            var result = _solution.Convert("A", 1);
            Assert.AreEqual("A", result);
        }
    }
}