using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class Program
    {
      
        public enum Options
        {
            BASIC = 1, INTERMEDIATE, ADVANCED
        }

        static void Main(string[] args)
        {

            int count = 3;
            do
            {
                string message = string.Format("Enter Your Choice {0}->basic , {1}->intermediate,{2}->advance ", Options.BASIC, Options.INTERMEDIATE, Option.ADVANCED);
                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->basic,{(int)Options.INTERMEDIATE}->intermediate, {(int)Options.ADVANCED}->advance ";
                Console.WriteLine(displayMessage);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());

                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("invalid option");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("choice should be number");
                }
                --count;

            }
            while (count > 0);
            switch (choice)
            {
                case Options.BASIC:
                    Console.WriteLine("Basic Level");
                    System.Reflection.Assembly basicLevelLib =
                     System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll");
                    System.Type basicLevelTypeclassRef = FindClass(basicLevelLib, "BasicLevelLib.BasicLevelType");
                    Object objRef = System.Activator.CreateInstance(basicLevelTypeclassRef);
                    System.Reflection.MethodInfo methodInfo = basicLevelTypeclassRef.GetMethod("play");
                    object result = InvokeMethod(objRef, methodInfo, new object[] { });
                    break;

                case Options.INTERMEDIATE:

                    Console.WriteLine("Intermediate Level");
                    System.Reflection.Assembly intermediateeLevelLib =
                    System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll");
                    System.Type intermediateLevelTypeclassRef = FindClass(intermediateeLevelLib, "IntermediateLevelLib.BasicLevelType");
                    Object objReference = System.Activator.CreateInstance(intermediateLevelTypeclassRef);
                    System.Reflection.MethodInfo methodInfo1 = intermediateLevelTypeclassRef.GetMethod("Start");
                    object _result = InvokeMethod(objReference, methodInfo1, new object[] { "ubed"});
                    break;
                   

                case Options.ADVANCED:
                    Console.WriteLine("Advance Level");
                    System.Reflection.Assembly advanceLevelLib =
                    System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\AdvanceLevelLib.dll");
                    System.Type advanceLevelTypeclassRef = FindClass(advanceLevelLib, "AdvanceLevelLib.BasicLevelType");
                    Object _objRef = System.Activator.CreateInstance(advanceLevelTypeclassRef);
                    System.Reflection.MethodInfo _methodInfo = advanceLevelTypeclassRef.GetMethod("Begin");
                    object result1 = InvokeMethod(_objRef, _methodInfo, new object[] {"ubed" ,100 });
                    break;

                   
            }


        }

        static System.Type FindClass(System.Reflection.Assembly _assemblyRef, string name)
        {
            System.Type classType = _assemblyRef.GetType(name);
            if (classType != null)
            {
                if (classType.IsClass)
                {
                    return classType;
                }
            }
            return null;
        }


        static object InvokeMethod(object source, System.Reflection.MethodInfo methodRef, object[] arguments)
        {
            return methodRef.Invoke(source, arguments);
        }

                
                

            }
          



}

        

    
