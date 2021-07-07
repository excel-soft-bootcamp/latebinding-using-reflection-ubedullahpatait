using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{

    public enum Options
    {
        BASIC =1,INTERMEDIATE,ADVANCED
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Word Guess Game");

            string message = string.Format("Enter Your Choice {0}->Basic , {1}->Intermediate ,{2}->Advanced", Options.BASIC, Options.INTERMEDIATE, Options.ADVANCED);// 1->Basic,2->Intermediate
            
            string displayMessage = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(displayMessage);
            Options _choice = (Options)Int32.Parse(Console.ReadLine());

            try
            {
                switch (_choice)
                {
                    case Options.BASIC:
                        Console.WriteLine("Basic Level");


                        System.Reflection.Assembly basicLevelLib =
                        System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\levellibs\BasicLevelLib.dll");

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
                        System.Reflection.Assembly.LoadFile(@"C:\\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\levellibs\AdvancedLevelLib.dll");

                        System.Type intermediateLevelTypeClassRef = intermediateLevelLib.GetType("BasicLevelLib.BasicLevelType");
                        if (intermediateLevelTypeClassRef != null)
                        {
                            if (intermediateLevelTypeClassRef.IsClass)
                            {


                                Object objRef = System.Activator.CreateInstance(intermediateLevelTypeClassRef);

                                System.Reflection.MethodInfo _methodRef = intermediateLevelTypeClassRef.GetMethod("Start");
                                if (!_methodRef.IsStatic)
                                {

                                    object result = _methodRef.Invoke(objRef, new object[] {"ubed"});
                                    Console.WriteLine(result.ToString());
                                }

                            }

                        }


                        break;
                    case Options.ADVANCED:
                        Console.WriteLine("Advanced Level");

                        System.Reflection.Assembly avancedLevelLib =
                       System.Reflection.Assembly.LoadFile(@"C:\Users\ubedullah.patait\source\repos\GameApp\GameApp\bin\Debug\levellibs\IntermediateLevelLib.dll");

                        System.Type avancedLevelTypeClassRef = avancedLevelLib.GetType("BasicLevelLib.BasicLevelType");
                        if (avancedLevelTypeClassRef != null)
                        {
                            if (avancedLevelTypeClassRef.IsClass)
                            {


                                Object objRef = System.Activator.CreateInstance(avancedLevelTypeClassRef);

                                System.Reflection.MethodInfo _methodRef = avancedLevelTypeClassRef.GetMethod("Begin");
                                if (!_methodRef.IsStatic)
                                {

                                    object result = _methodRef.Invoke(objRef, new object[] {"ubed" , 400 });
                                    Console.WriteLine(result.ToString());
                                }

                            }

                        }

                        break;

                }


            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("out of range");
            }
            

        }


    }
    }

