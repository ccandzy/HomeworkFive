using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("土豆切块", DishContext.PrintColor);
            PrintHelper.PrintWrite("茄子切块", DishContext.PrintColor);
            PrintHelper.PrintWrite("豆角切块", DishContext.PrintColor);
            PrintHelper.PrintWrite("大火翻炒", DishContext.PrintColor);
        }
        

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
