using System;
using System.Reflection;

namespace MoodAnalyser
{
    /// <summary>
    /// Creating object at runtime using Reflections with default constructor.
    /// </summary>
    public class MoodAnalyserFactory
    {
        public static object CreateObjectAtRuntime()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
            Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
            object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
            return moodAnalyserObject;
        }
    }
}