namespace NHelpfulExceptions.Test.Fast
{
    using NUnit.Framework;

    [TestFixture]
    public class ArrayExtensionsTests
    {
        [Test]
        public void ToPrettyPrintList_HappyPath_ReturnsCorrectString()
        {
            var a = new[] {"one", "two"};

            var delimitedString = a.ToPrettyPrintList(listPrefix:"List items:\r\n", 
                                                      listItemPrefix:" - ", 
                                                      listItemDelimiter:"\r\n", 
                                                      listSuffix:"...");

            Assert.That(delimitedString == 
@"List items:
 - one
 - two...");
        }

        [Test]
        public void ToPrettyPrintList_MissingListPrefix_ReturnsCorrectString()
        {
            var a = new[] { "one", "two" };

            var delimitedString = a.ToPrettyPrintList(listItemPrefix: " - ",
                                                      listItemDelimiter: "\r\n",
                                                      listSuffix: "...");

            Assert.That(delimitedString ==
@" - one
 - two...");
        }

        [Test]
        public void ToPrettyPrintList_MissingListItemPrefix_ReturnsCorrectString()
        {
            var a = new[] { "one", "two" };

            var delimitedString = a.ToPrettyPrintList(
                                                      listPrefix: "List items:\r\n",
                                                      listItemDelimiter: "\r\n",
                                                      listSuffix: "...");

            Assert.That(delimitedString ==
@"List items:
one
two...");
        }

        [Test]
        public void ToPrettyPrintList_MissingListItemDelimiter_ReturnsCorrectString()
        {
            var a = new[] { "one", "two" };

            var delimitedString = a.ToPrettyPrintList(
                                                      listPrefix: "List items:\r\n",
                                                      listItemPrefix: " - ", 
                                                      listSuffix: "...");

            Assert.That(delimitedString ==
@"List items:
 - one - two...");
        }

        [Test]
        public void ToPrettyPrintList_MissingListSuffix_ReturnsCorrectString()
        {
            var a = new[] { "one", "two" };

            var delimitedString = a.ToPrettyPrintList(listPrefix: "List items:\r\n",
                                                      listItemPrefix: " - ",
                                                      listItemDelimiter: "\r\n");

            Assert.That(delimitedString ==
@"List items:
 - one
 - two");
        }
    }
}