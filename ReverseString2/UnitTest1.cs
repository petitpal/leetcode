using NUnit.Framework;

namespace ReverseString2
{
    public class Tests
    {
        private Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var input = new char[] { 'o', 'l', 'l', 'e', 'h' };
            var expectedOutput = new char[] { 'h', 'e', 'l', 'l', 'o' };

            // Act
            solution.ReverseString(input);

            // Assert
            Assert.AreEqual(input, expectedOutput);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var input = new char[] { 'l', 'l', 'e', 'h' };
            var expectedOutput = new char[] { 'h', 'e', 'l', 'l' };

            // Act
            solution.ReverseString(input);

            // Assert
            Assert.AreEqual(input, expectedOutput);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var input = new char[] { 'l', 'e', 'h' };
            var expectedOutput = new char[] { 'h', 'e', 'l' };

            // Act
            solution.ReverseString(input);

            // Assert
            Assert.AreEqual(input, expectedOutput);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var input = new char[] { 'e', 'h' };
            var expectedOutput = new char[] { 'h', 'e' };

            // Act
            solution.ReverseString(input);

            // Assert
            Assert.AreEqual(input, expectedOutput);
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var input = new char[] { 'h' };
            var expectedOutput = new char[] { 'h' };

            // Act
            solution.ReverseString(input);

            // Assert
            Assert.AreEqual(input, expectedOutput);
        }
    }
}