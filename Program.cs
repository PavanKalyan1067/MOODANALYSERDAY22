using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser program using Exceptions");

            MoodAnalyserr moodAnalyserr = new MoodAnalyserr();
            Console.WriteLine(moodAnalyserr.MoodCheck("Iam in Sad Mood"));
            Console.WriteLine(moodAnalyserr.MoodCheck("Iam in Any Mood"));
        }
    }
}