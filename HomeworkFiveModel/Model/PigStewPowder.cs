using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class PigStewPowder : AbstractFood
    {
        public PigStewPowder()
        {
            Id = 4;
            Name = "猪肉炖粉条";
        }

        public override void DoDish()
        {
            throw new NotImplementedException();
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
