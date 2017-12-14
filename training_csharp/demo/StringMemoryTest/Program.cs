using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace StringMemoryTest
{
    public class CommandLineParameter
    {
        public int Count { get; set; }
        public string TestMode { get; set; }
    }

    class Program
    {
        private static List<string> container = new List<string>();

        private const string TestMode_Intern = "with-intern";
        private const string TestMode_WithoutIntern = "without-intern";

        static void Main(string[] args)
        {
            try
            {
                var parmater = GetParameter(args);

                if (TestMode_WithoutIntern.Equals(parmater.TestMode))
                {
                    GenerateStringWithoutIntern(parmater.Count);
                }
                else
                {
                    GenerateStringWithIntern(parmater.Count);
                }
            }
            catch (ArgumentException)
            {
                DisplayUseage();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine();
                Console.Write("Press any key to quit.");
                Console.ReadKey();
            }
        }

        private static CommandLineParameter GetParameter(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException();
            }

            var testMode = args[0];

            if (!TestMode_Intern.Equals(testMode) && !TestMode_WithoutIntern.Equals(testMode))
            {
                throw new ArgumentException();
            }
             
            var stringCount = 0;

            if (!int.TryParse(args[1], out stringCount))
            {
                throw new ArgumentException();
            }

            if (stringCount <= 0)
            {
                throw new ArgumentException();
            }

            return new CommandLineParameter
            {
                Count = stringCount,
                TestMode = testMode
            };
        }

        private static void DisplayUseage()
        {
            Console.WriteLine();
            Console.WriteLine("String Memory Test v1.0");
            Console.WriteLine("Usage:");
            Console.WriteLine("     <executable.exe> <test-mode> <string count>");
            Console.WriteLine();
            Console.WriteLine("     <test-mode>    : string, availible values are without-intern,with-intern");
            Console.WriteLine("     <string count> : integer, how many string it will be generated for memory test.");
            Console.WriteLine();
            Console.WriteLine("Example:");
            Console.WriteLine();
            Console.WriteLine("     strmemtest with-intern 10000");
            Console.WriteLine("         this will run test with 10000 string in intern mode.");
            Console.WriteLine();
        }

        private static void GenerateStringWithIntern(int count)
        {
            Console.WriteLine("Generating string with intern ...");

            for (var x = 0; x < count; x++)
            {
                var content = BuildTestString();

                container.Add(string.Intern(content.ToString()));

                Console.CursorLeft = 0;
                Console.Write("{0}/{1}", x + 1, count);
            }
        }

        private static void GenerateStringWithoutIntern(int count)
        {
            Console.WriteLine("Generating string without intern ...");

            for (var x = 0; x < count; x++)
            {
                var content = BuildTestString();

                container.Add(content.ToString());

                Console.CursorLeft = 0;
                Console.Write("{0}/{1}", x+1, count);
            }
        }

        private static StringBuilder BuildTestString()
        {
            return new StringBuilder("Test String value for memory test");
        }
    }
}
