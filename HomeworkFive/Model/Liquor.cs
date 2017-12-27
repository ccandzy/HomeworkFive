using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class Liquor:BaseSoup
    {
        public Liquor()
        {
            Id = 1;
            Name = "白酒汤";
        }


        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★★");
        }

    }
}
