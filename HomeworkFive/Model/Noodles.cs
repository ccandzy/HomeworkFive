using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class Noodles:BaseFood
    {
        public Noodles()
        {
            Id = 30;
            Name = "面条";
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★");
        }
    }
}
