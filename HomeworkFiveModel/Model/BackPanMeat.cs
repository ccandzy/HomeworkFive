using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("取肥肉", DishContext.PrintColor);
            PrintHelper.PrintWrite("油炸", DishContext.PrintColor);
            PrintHelper.PrintWrite("回锅", DishContext.PrintColor);
        }
        
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
