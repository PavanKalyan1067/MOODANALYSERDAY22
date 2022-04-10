using System;
using System.Reflection;
namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyser.MoodAnalyser");
            object objName = moodAnalyserFactory.CreateObjectAtRuntime();
            Console.WriteLine(objName);
        }
    }
}