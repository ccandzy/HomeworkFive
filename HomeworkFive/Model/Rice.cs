using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class Rice:BaseFood
    {
        public Rice()
        {
            Id = 30;
            Name = "米饭";
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★");
        }
    }
}
