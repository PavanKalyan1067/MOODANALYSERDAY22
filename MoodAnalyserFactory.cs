using System;
using System.Reflection;
namespace MoodAnalyser
{
    /// <summary>
    /// Creating object at runtime using Reflections with default constructor.
    /// </summary>
    public class MoodAnalyserFactory
    {
       
        public static object CreateObjectAtRuntime(string className)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(className);
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
                return moodAnalyserObject;
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Done Reflections");
            }
            return null;
        }
    }
}