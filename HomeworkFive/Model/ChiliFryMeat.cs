using System;

namespace HomeworkFive.Model
{
    public class ChiliFryMeat:BaseDish
    {
        public ChiliFryMeat()
        {
            Id = 1;
            Name = "辣椒炒肉";
        }

        public override void PointDish(PointDishContext pointDishContext)
        {
            Console.WriteLine($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}");
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★★");
        }
    }
}
