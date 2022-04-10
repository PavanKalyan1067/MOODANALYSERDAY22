using System;
namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        private Errors cLASS_ERROR;

        public enum Errors
        {
            EMPTY,
            CLASS_ERROR,
            METHOD_ERROR
        }
        /// <summary>
        /// custom exception for mood analysis. display an empty message.
        /// </summary>
        public MoodAnalysisException(string message)
        {
            if (message == null || message == string.Empty)
            {
                Console.WriteLine(Errors.EMPTY + ": Mood cannot be empty.");
            }
            else if (message.Contains("Mood"))
            {
                Console.WriteLine(Errors.CLASS_ERROR + ": No Such Class Error.");
            }
        }

        public MoodAnalysisException(Errors cLASS_ERROR)
        {
            this.cLASS_ERROR = cLASS_ERROR;
        }
    }
}