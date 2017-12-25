using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class TasteSnake : BaseDish
    {
        public TasteSnake()
        {
            Id = 2;
            Name = "口味蛇";
        }

        public override void PointDish(PointDishContext pointDishContext)
        {
            Console.WriteLine($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}");
        }

        public override void Show()
        {
            Console.WriteLine("This is 口味蛇,推荐指数:★★★");
        }
    }
}
