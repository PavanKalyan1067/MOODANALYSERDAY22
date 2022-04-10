namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        //constants
     
        private const string HAPPY_MESSAGE = "Iam in Any Mood";
        
        public string MoodCheck(string message)
        {
    
            if (message == HAPPY_MESSAGE)
                return "HAPPY";
            return null;
        }
    }
}