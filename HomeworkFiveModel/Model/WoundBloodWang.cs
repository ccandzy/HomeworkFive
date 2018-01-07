using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class WoundBloodWang : AbstractFood
    {
        public WoundBloodWang()
        {
            Id = 3;
            Name = "毛血旺";
        }

        public override void DoDish()
        {
            PrintHelper.PrintWrite("取猪血", DishContext.PrintColor);
            PrintHelper.PrintWrite("油炸", DishContext.PrintColor);
            PrintHelper.PrintWrite("上火锅", DishContext.PrintColor);
        }

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
