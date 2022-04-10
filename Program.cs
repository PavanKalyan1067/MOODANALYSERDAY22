using System;
namespace MoodAnalyser
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser program using Exceptions");

            //MoodAnalyserr moodAnalyserr = new MoodAnalyserr("Iam in Sad Mood");
            MoodAnalyserr moodAnalyserr = new MoodAnalyserr("Iam in Any Mood");


            Console.WriteLine(moodAnalyserr.MoodCheck());

        }
    }
}