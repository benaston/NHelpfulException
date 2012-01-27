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

namespace NHelpfulException
{
	using System;

	/// <summary>
	/// 	When used as a base for custom exceptions, forces the supply of a message upon instantiation.
	/// </summary>
	public class HelpfulException : Exception
	{
		public static readonly string ResolutionSuggestionListPrefix = "\r\nSuggestions:\r\n";
		public static readonly string ResolutionSuggestionPrefix = " - ";
		public static readonly string ResolutionSuggestionDelimiter = "\r\n";
		public static readonly string ResolutionSuggestionListSuffix = "\r\n";

		public HelpfulException(string problemDescription,
		                        string[] resolutionSuggestions = default(string[]),
		                        Exception innerException = default(Exception))
			: base(problemDescription + resolutionSuggestions.ToPrettyPrintList(ResolutionSuggestionListPrefix,
			                                                                    ResolutionSuggestionPrefix,
			                                                                    ResolutionSuggestionDelimiter,
			                                                                    ResolutionSuggestionListSuffix),
			       innerException) {}
	}
}