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
	using System;
	using NUnit.Framework;

	[TestFixture]
	public class HelpfulExceptionTests
	{
		private class TestException : HelpfulException
		{
			public TestException(string problemDescription, string[] resolutionSuggestions, Exception innerException)
				: base(problemDescription, resolutionSuggestions, innerException) {}
		}

		[Test]
		public void Constructor_HappyPath_InitializesCorrectExceptionMessage()
		{
			var e = new TestException("Problem in A.", new[] {"try x", "try y", "try z"}, null);


			Assert.That(e.Message ==
			            @"Problem in A.
Suggestions:
 - try x
 - try y
 - try z
");
		}
	}
}