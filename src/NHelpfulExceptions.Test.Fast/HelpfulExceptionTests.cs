namespace NHelpfulExceptions.Test.Fast
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class HelpfulExceptionTests
    {
        [Test]
        public void Constructor_HappyPath_InitializesCorrectExceptionMessage()
        {
            var e = new TestException("Problem in A.", new[] { "try x", "try y", "try z" }, null);

            
            Assert.That(e.Message == 
@"Problem in A.
Suggestions:
 - try x
 - try y
 - try z
");
        }

        private class TestException : HelpfulException
        {
            public TestException(string problemDescription, string[] resolutionSuggestions, Exception innerException) : base(problemDescription, resolutionSuggestions, innerException) { }
        }
    }
}