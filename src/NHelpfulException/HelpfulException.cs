namespace NHelpfulException
{
    using System;

    /// <summary>
    ///   When used as a base for custom exceptions, 
    ///   forces the supply of a message upon instantiation.
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