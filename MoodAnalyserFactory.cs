using System;
using System.Reflection;
namespace MoodAnalyser
{
    /// <summary>
    /// Creating object at runtime using Reflections with default constructor.
    /// </summary>
    public class MoodAnalyserFactory
    {
        //variable
        private readonly string className;

        public MoodAnalyserFactory(string className)
        {
            this.className = className;
        }
        //constructor without parameters
        public MoodAnalyserFactory()
        {
            this.className = "MoodAnalyser.MoodAnalyserr";
        }
        Type moodAnalyserType;
        object moodAnalyserObject;
        Assembly assembly = Assembly.GetExecutingAssembly();

        public object CreateObjectAtRuntime()
        {
            try
            {
                //variable

                moodAnalyserType = assembly.GetType(this.className);
                //if class name is invalid will throw an exception.
                if (moodAnalyserType == null)
                    throw new MoodAnalysisException(MoodAnalysisException.Errors.CLASS_ERROR);
                else
                {
                    //creata an object with Constructor.
                    moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
                    ConstructorInfo constructor = GetConstructor();
                    var conObj = CreateConstructor(this.className, constructor);
                    Console.WriteLine("Constructor object: " + conObj);
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

        public object CreateConstructor(string className, ConstructorInfo constructor)
        {


            if (className != moodAnalyserType.FullName)
                throw new MoodAnalysisException(MoodAnalysisException.Errors.CLASS_ERROR);
            //constructor name should be same as Constructor in this case we are checking for non parameteized constructor.
            if (constructor != moodAnalyserType.GetConstructors()[0])
                throw new MoodAnalysisException(MoodAnalysisException.Errors.METHOD_ERROR);
            //we create an constructor with create instance method.
            var constructorObj = Activator.CreateInstance(moodAnalyserType);
            return constructorObj;
        }

        public ConstructorInfo GetConstructor(int parameter = 0)
        {
            try
            {
                moodAnalyserType = assembly.GetType(this.className);
                ConstructorInfo[] constructorInfo = moodAnalyserType.GetConstructors();
                foreach (ConstructorInfo constructor in constructorInfo)
                {
                    //checking for cosntructor with no parameters
                    if (constructor.GetParameters().Length == parameter)
                        return constructor;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //getting constuctors from the class.
            return null;
        }
    }
}
