using log4net;
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
        private static ILog log = LogManager.GetLogger(typeof(PrintHelper));

        public static void PrintWrite(string writeMessage,ConsoleColor consoleColor=ConsoleColor.White)
        {
            lock(lockObject)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(writeMessage);
                log.Info(writeMessage);
            }
        }
    }
}
