using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class HuNanSoup : BaseSoup
    {
        public HuNanSoup()
        {
            Id = 20;
            Name = "湖南汤";
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★★");
        }
    }
}
