// Copyright 2011, Ben Aston (ben@bj.ma).
// 
// This file is part of NHelpfulException.
// 
// NHelpfulException is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// NHelpfulException is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with NHelpfulException.  If not, see <http://www.gnu.org/licenses/>.

namespace NHelpfulException.Test.Fast
{
	using NUnit.Framework;

	[TestFixture]
	public class ArrayExtensionsTests
	{
		[Test]
		public void ToPrettyPrintList_HappyPath_ReturnsCorrectString()
		{
			var a = new[] {"one", "two"};

			var delimitedString = a.ToPrettyPrintList(listPrefix: "List items:\r\n",
			                                          listItemPrefix: " - ",
			                                          listItemDelimiter: "\r\n",
			                                          listSuffix: "...");

			Assert.That(delimitedString ==
			            @"List items:
 - one
 - two...");
		}

		[Test]
		public void ToPrettyPrintList_MissingListItemDelimiter_ReturnsCorrectString()
		{
			var a = new[] {"one", "two"};

			var delimitedString = a.ToPrettyPrintList(
				listPrefix: "List items:\r\n",
				listItemPrefix: " - ",
				listSuffix: "...");

			Assert.That(delimitedString ==
			            @"List items:
 - one - two...");
		}

		[Test]
		public void ToPrettyPrintList_MissingListItemPrefix_ReturnsCorrectString()
		{
			var a = new[] {"one", "two"};

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
		public void ToPrettyPrintList_MissingListPrefix_ReturnsCorrectString()
		{
			var a = new[] {"one", "two"};

			var delimitedString = a.ToPrettyPrintList(listItemPrefix: " - ",
			                                          listItemDelimiter: "\r\n",
			                                          listSuffix: "...");

			Assert.That(delimitedString ==
			            @" - one
 - two...");
		}

		[Test]
		public void ToPrettyPrintList_MissingListSuffix_ReturnsCorrectString()
		{
			var a = new[] {"one", "two"};

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