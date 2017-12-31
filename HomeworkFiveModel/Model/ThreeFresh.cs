using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class ThreeFresh : AbstractFood
    {
        public ThreeFresh()
        {
            Id = 6;
            Name = "地三鲜";
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
