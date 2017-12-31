using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class EggFriedRice : AbstractFood
    {
        public EggFriedRice()
        {
            Id = 8;
            Name = "蛋炒饭";
        }

        public override void DoDish()
        {
            
        }

        public override void PointDish(DishContext pointDishContext)
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
