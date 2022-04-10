using System;

namespace MoodAnalyser
{
    public class MoodAnalyserr

    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
        private const string HAPPY_MESSAGE = "Iam in Any Mood";
        //variables
        private string message;
        public MoodAnalyserr(string message)
        {
            this.message = message;
        }

        public string MoodCheck()
        {
            try
            {
                if (message == null)
                    throw new Exception("Invalid Mood");
                if (message == SAD_MESSAGE)
                    return "SAD";
                if (message == HAPPY_MESSAGE)
                    return "HAPPY";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

 
