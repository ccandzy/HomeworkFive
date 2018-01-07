using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;
using System;

namespace HomeworkFiveGuangDongModel
{
    public class WhiteCutChicken : AbstractFood
    {
        public WhiteCutChicken()
        {
            Id = 9;
            Name = "白切鸡";
        }

        public override void DoDish()
        {
            PrintHelper.PrintWrite("半边鸡块", DishContext.PrintColor);
            PrintHelper.PrintWrite("均匀切好", DishContext.PrintColor);
            PrintHelper.PrintWrite("蒸50分钟", DishContext.PrintColor);
        }
        

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
