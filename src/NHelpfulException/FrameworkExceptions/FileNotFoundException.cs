namespace NHelpfulException.FrameworkExceptions
{
    using System;

    /// <summary>
    ///   Responsible for defining an ArgumentException that 
    ///   is guaranteed to have a constructor accepting a string 
    ///   to set the exception message.
    /// </summary>
    public class FileNotFoundException : HelpfulException
    {
		public FileNotFoundException(string problemDescription, string[] resolutionSuggestions = default(string[]), Exception innerException = default(Exception)) : base(problemDescription, resolutionSuggestions, innerException) { }
    }
}