using System;
namespace MoodAnalyser
{
    class MoodAnalysisException : Exception
    {
        public enum Errors { EMPTY }
       
        public MoodAnalysisException()
        {
            Console.WriteLine(Errors.EMPTY);
        }
    }
}