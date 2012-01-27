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

	public static class ArrayExtensions
	{
		/// <summary>
		/// 	Renders an array of T to a pretty-printed string.
		/// </summary>
		public static string ToPrettyPrintList<T>(this T[] items,
		                                          string listPrefix = null,
		                                          string listItemPrefix = null,
		                                          string listItemDelimiter = null,
		                                          string listSuffix = null)
		{
			if (items == null || items.Length == 0)
			{
				return String.Empty;
			}

			var returnValue = listPrefix ?? String.Empty;

			for (var x = 0; x < items.Length; x++)
			{
				returnValue += (listItemPrefix ?? String.Empty) + items[x];
				if (x == items.Length - 1)
				{
					break;
				}

				returnValue += (listItemDelimiter ?? String.Empty);
			}

			returnValue += listSuffix ?? String.Empty;

			return returnValue;
		}
	}
}