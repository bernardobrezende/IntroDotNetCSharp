using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Console
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
#if DEBUG
            System.Console.WriteLine("Running with debug configuration!");
#endif
            System.Console.WriteLine("Hello World");

            #region Reading keyboard line from user

            string name = System.Console.ReadLine();
            System.Console.WriteLine(name);

            #endregion
        }
    }
}