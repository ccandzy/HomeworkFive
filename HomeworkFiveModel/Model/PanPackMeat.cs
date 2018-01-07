using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("取荷叶",DishContext.PrintColor);
            PrintHelper.PrintWrite("大火闷1小时", DishContext.PrintColor);
        }
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
