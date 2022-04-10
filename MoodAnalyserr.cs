namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
        private const string HAPPY_MESSAGE = "Iam in Any Mood";


        public string MoodCheck(string message)
        {
            if (message == SAD_MESSAGE)
                return "SAD";
            if (message == HAPPY_MESSAGE)
                return "HAPPY";
            return null;
        }
    }
}