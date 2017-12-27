using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class PanPackMeat : BaseDish
    {
        public PanPackMeat()
        {
            Id = 1;
            Name = "锅包肉";
           
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
