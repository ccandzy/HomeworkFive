using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class ThreeFresh : BaseDish
    {
        public ThreeFresh()
        {
            Id = 2;
            Name = "地三鲜";
        }

        public override void PointDish(PointDishContext pointDishContext)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★★");
        }
    }
}
