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

namespace NHelpfulException.FrameworkExceptions
{
	using System;

	/// <summary>
	/// 	Responsible for defining an ArgumentException that is guaranteed to have a constructor accepting a string to set the exception message.
	/// </summary>
	public class ArgumentException : HelpfulException
	{
		public ArgumentException(string problemDescription, string[] resolutionSuggestions = default(string[]),
		                         Exception innerException = default(Exception))
			: base(problemDescription, resolutionSuggestions, innerException) {}
	}
}