using System;
using System.Reflection;
namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoodAnalyserr mood = new MoodAnalyserr("");
            //mood.MoodCheck();
            Console.WriteLine("Mood Analyser program using Reflections");
            ////creating an instance of an Class at Compile time.
            //MoodAnalyserr moodAnalyserr = new MoodAnalyserr();
            //Console.WriteLine("Mood is : " + moodAnalyserr.MoodCheck());

            //// method to create an instance of class at Run Time.
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyserr");
            //object objName = moodAnalyserFactory.CreateObjectAtRuntime();
            //Console.WriteLine("object of the class :" + objName);
            moodAnalyserFactory.InvokeMethod();
        }
    }
}