namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        //constants
        private const string SAD_MESSAGE = "Iam in Sad Mood";
     


        public string MoodCheck(string message)
        {
            if (message == SAD_MESSAGE)
                return "SAD";
       
            return null;
        }
    }
}