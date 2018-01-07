using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("取冷饭", DishContext.PrintColor);
            PrintHelper.PrintWrite("炒鸡蛋", DishContext.PrintColor);
            PrintHelper.PrintWrite("倒入饭", DishContext.PrintColor);
        }
        
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
