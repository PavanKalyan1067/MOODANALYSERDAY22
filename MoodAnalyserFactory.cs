using System;
using System.Reflection;
namespace MoodAnalyser
{
    
    public class MoodAnalyserFactory
    {
        
        /// 
        private string className;
        public MoodAnalyserFactory(string className)
        {
            this.className = className;
        }
        public MoodAnalyserFactory()
        {

        }
        public object CreateObjectAtRuntime()
        {
            try
            {
                //variable
                object moodAnalyserObject;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                else
                {
                    Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                    //creating an object with parameterized Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType, "this is a message");
                }
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

        public object CreateObjectAtRuntime(string className)
        {
            try
            {
                //variable
                object moodAnalyserObject;
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(className);
                else
                {
                    Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                    //creating an object with parameterized Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType, "MoodAnalyser.MoodAnalyserr");
                }
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