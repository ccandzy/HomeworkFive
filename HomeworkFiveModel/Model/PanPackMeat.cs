using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class PanPackMeat : AbstractFood
    {
        public PanPackMeat()
        {
            Id = 5;
            Name = "锅包肉";
           
        }

        public override void DoDish()
        {
            
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
