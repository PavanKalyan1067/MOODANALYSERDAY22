using System;
using System.Reflection;
namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Mood Analyser program using Reflections");
            ////creating an instance of an Class at Compile time.
            //MoodAnalyserr moodAnalyserr = new MoodAnalyserr("");
            //Console.WriteLine(" Method called at Compile time : " + moodAnalyserr.MoodCheck("Iam in Sad Mood"));
            //Static method to create an instance of class at Compile Time.
            object objName = MoodAnalyserFactory.CreateObjectAtRuntime();
            //Console.WriteLine(objName);
        }
    }
}