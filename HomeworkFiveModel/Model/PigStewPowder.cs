using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("取猪肉",DishContext.PrintColor);
            PrintHelper.PrintWrite("泡粉条", DishContext.PrintColor);
            PrintHelper.PrintWrite("大火炖一小时", DishContext.PrintColor);
        }
        
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
