using System;
namespace MoodAnalyser
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser program using Exceptions");

            MoodAnalyserr moodAnalyserr = new MoodAnalyserr(null);
            Console.WriteLine(moodAnalyserr.MoodCheck());
        }
    }
}