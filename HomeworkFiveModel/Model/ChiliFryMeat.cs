using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class ChiliFryMeat:AbstractFood
    {
        public ChiliFryMeat()
        {
            Id = 1;
            Name = "辣椒炒肉";
        }

        public override void DoDish()
        {
            
        }

        public override void PointDish(DishContext pointDishContext)
        {
            Console.WriteLine($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
