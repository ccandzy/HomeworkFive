using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class WoundBloodWang : BaseDish
    {
        public WoundBloodWang()
        {
            Id = 3;
            Name = "毛血旺";
        }

        public override void PointDish(PointDishContext pointDishContext)
        {
            Console.WriteLine($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}");
        }

        public override void Show()
        {
            Console.WriteLine("This is 毛血旺,推荐指数:★★★★");
        }
    }
}
