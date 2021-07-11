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
            BASIC= 1,INTERMEDIATE,ADVANCED
        }
        static void Main(string[] args)
        {


            int count=3;
           

            do
            {
                string message = string.Format("Enter Your Choice {0}->basic , {1}->intermediate,{2}->advance ", Options. BASIC, Options.INTERMEDIATE,Option.ADVANCED); 
                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->basic,{(int)Options.INTERMEDIATE}->intermediate, {(int)Options.ADVANCED}->advance ";
                Console.WriteLine(displayMessage);
                try
                {
                    int choice = (Options)Int32.Parse(Console.ReadLine());

                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("invalid option");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex )
                {
                    Console.WriteLine("choice should be number");
                }
                --count;

            }
            while (count > 0);


                switch (_choice)
                {
                    case Options.BASIC:
                        Console.WriteLine("Basic Level");
                        System.Reflection.Assembly basicLevelLib =
                                 System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll");
                        System.Type basicLevelTypeClassRef = basicLevelLib.GetType("BasicLevelLib.BasicLevelType");
                        if (basicLevelTypeClassRef != null)
                        {
                            if (basicLevelTypeClassRef.IsClass)
                            {
                                Object objRef = System.Activator.CreateInstance(basicLevelTypeClassRef);
                                System.Reflection.MethodInfo _methodRef = basicLevelTypeClassRef.GetMethod("Play");
                                if (!_methodRef.IsStatic)
                                {
                                    object result = _methodRef.Invoke(objRef, new object[] { });
                                    Console.WriteLine(result.ToString());
                                }

                            }

                        }
                        break;

                    case Options.INTERMEDIATE:
                        Console.WriteLine("Intermediate Level");
                        System.Reflection.Assembly intermediateLevelLib =
                            System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll");
                        System.Type intermediateLevelTypeClassRef = intermediateLevelLib.GetType("IntermediateLevelLib.IntermediateLevelType");
                        if (intermediateLevelTypeClassRef != null)
                        {
                            if (intermediateLevelTypeClassRef.IsClass)
                            {
                                Object intermediateObj = System.Activator.CreateInstance(intermediateLevelTypeClassRef);
                                System.Reflection.MethodInfo methodRef = intermediateLevelTypeClassRef.GetMethod("Start");

                                if (!methodRef.IsStatic)
                                {
                                    object result = methodRef.Invoke(intermediateObj, new object[] { "ubed" });
                                    Console.WriteLine(result.ToString());
                                }
                            }
                        }

                        break;

                    case Options.ADVANCED:
                        Console.WriteLine("Advanced Level");
                        System.Reflection.Assembly advancedLevelLib =
                            System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll");
                        System.Type advancedLevelTypeClassRef = advancedLevelLib.GetType("AdvancedLevelLib.AdvancedLevelType");
                        if (advancedLevelTypeClassRef != null)
                        {
                            if (advancedLevelTypeClassRef.IsClass)
                            {
                                Object advancedObj = System.Activator.CreateInstance(advancedLevelTypeClassRef);
                                System.Reflection.MethodInfo methodRef = advancedLevelTypeClassRef.GetMethod("Begin");
                                if (!methodRef.IsStatic)
                                {
                                    object result = methodRef.Invoke(advancedObj, new object[] { "ubed", 100 });
                                    Console.WriteLine(result.ToString());
                                }
                            }
                        }
                        break;

                  


                
                

            }
          





        }

    }
}
