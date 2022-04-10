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
            if (message == SAD_MESSAGE)
                return "SAD";

            if (message == HAPPY_MESSAGE)
                return "HAPPY";
            return null;
        }
        public string MoodCheck1()
        {

            if (message == HAPPY_MESSAGE)
                return "HAPPY";
            if (message == SAD_MESSAGE)
                return "SAD";
            return null;
        }
    }
}