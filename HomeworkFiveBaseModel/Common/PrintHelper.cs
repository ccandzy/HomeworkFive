using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFiveBaseModel.Common
{
    public class PrintHelper
    {
        private static object lockObject = new object();
        public static void PrintWrite(string writeMessage,ConsoleColor consoleColor=ConsoleColor.White)
        {
            lock(lockObject)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(writeMessage);
            }
        }
    }
}
