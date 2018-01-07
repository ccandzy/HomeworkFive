using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("放入肉", DishContext.PrintColor);
            PrintHelper.PrintWrite("放入辣椒", DishContext.PrintColor);
        }
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
