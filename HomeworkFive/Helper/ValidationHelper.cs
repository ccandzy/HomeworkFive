using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Helper
{
    public class ValidationHelper
    {
        public static bool ValidationUserEnter(string sEnter,out int userEnter)
        {
            if (!int.TryParse(sEnter, out userEnter))
            {
                Console.WriteLine("输入字符串不正确！");
                return false;
            }
            return true;
        }
    }
}
