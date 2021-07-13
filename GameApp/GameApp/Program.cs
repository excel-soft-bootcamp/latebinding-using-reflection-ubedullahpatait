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
            // Options choice = default(Options);
            do
            {
                string message = string.Format("Enter Your Choice {0}->basic , {1}->intermediate,{2}->advance ", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);
                string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->basic,{(int)Options.INTERMEDIATE}->intermediate, {(int)Options.ADVANCED}->advance ";
                Console.WriteLine(displayMessage);
                try
                {
                    Options choice = (Options)Int32.Parse(Console.ReadLine());
                    

                    if (choice == Options.BASIC || choice == Options.INTERMEDIATE || choice == Options.ADVANCED)
                    {
                        switch (choice)
                        {
                            case Options.BASIC:
                                Console.WriteLine("Basic Level");
                                System.Reflection.Assembly basicLevelLib =
                                 System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\Documents\GitHub\latebinding-using-reflection-ubedullahpatait\GameApp\GameApp\bin\Debug\LevelLibs\BasicLevelLib.dll");
                                System.Type basicLevelTypeclassRef = CheckConditionLib.CheckConditionType.FindClass(basicLevelLib, "BasicLevelLib.BasicLevelType");
                                Object objRef = System.Activator.CreateInstance(basicLevelTypeclassRef);
                                System.Reflection.MethodInfo methodInfo = basicLevelTypeclassRef.GetMethod("Play");
                                object result = CheckConditionLib.CheckConditionType.InvokeMethod(objRef, methodInfo, new object[] { });
                                Console.WriteLine(result.ToString());
                                break;

                            case Options.INTERMEDIATE:

                                Console.WriteLine("Intermediate Level");
                                System.Reflection.Assembly intermediateeLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\Documents\GitHub\latebinding-using-reflection-ubedullahpatait\GameApp\GameApp\bin\Debug\LevelLibs\IntermediateLevelLib.dll");
                                System.Type intermediateLevelTypeclassRef = CheckConditionLib.CheckConditionType.FindClass(intermediateeLevelLib, "IntermediateLevelLib.IntermediateLevelType");
                                Object objReference = System.Activator.CreateInstance(intermediateLevelTypeclassRef);
                                System.Reflection.MethodInfo methodInfo1 = intermediateLevelTypeclassRef.GetMethod("Start");
                                object result1 = CheckConditionLib.CheckConditionType.InvokeMethod(objReference, methodInfo1, new object[] { "ubed" });
                                Console.WriteLine(result1.ToString());
                                break;


                            case Options.ADVANCED:
                                
                                Console.WriteLine("Advance Level");
                                System.Reflection.Assembly advanceLevelLib =
                                System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\Documents\GitHub\latebinding-using-reflection-ubedullahpatait\GameApp\GameApp\bin\Debug\LevelLibs\AdvancedLevelLib.dll");
                                System.Type advanceLevelTypeclassRef = CheckConditionLib.CheckConditionType.FindClass(advanceLevelLib, "AdvancedLevelLib.AdvancedLevelType");
                                Object _objRef = System.Activator.CreateInstance(advanceLevelTypeclassRef);
                                System.Reflection.MethodInfo _methodInfo = advanceLevelTypeclassRef.GetMethod("Begin");
                                object result3 =CheckConditionLib.CheckConditionType.InvokeMethod(_objRef, _methodInfo, new object[] { "ubed", 100 });
                                Console.WriteLine(result3.ToString());
                                
                                break;


                        }


                    }


                    else
                    {
                        Console.WriteLine("invalid option");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("choice should be number");
                }
                --count;

            }
            while (count > 0);
            Console.ReadKey();
        }



       

    }
}
