namespace NHelpfulExceptions
{
    using System;

    public static class ArrayExtensions
    {
        /// <summary>
        /// Renders an array of T to a pretty-printed string.
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