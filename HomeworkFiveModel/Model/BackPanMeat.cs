using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class BackPanMeat : AbstractFood
    {
        public BackPanMeat()
        {
            Id = 7;
            Name = "回锅肉";
        }

        public override void DoDish()
        {
            throw new NotImplementedException();
        }

        public override void PointDish(DishContext pointDishContext)
        {
        }
        

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
