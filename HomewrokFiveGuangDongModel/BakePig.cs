using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveGuangDongModel
{
    public class BakePig : AbstractFood
    {
        public BakePig()
        {
            Id = 10;
            Name = "烤乳猪";
            
        }
        public override void DoDish()
        {
            PrintHelper.PrintWrite("取整猪",DishContext.PrintColor);
            PrintHelper.PrintWrite("木材烧火", DishContext.PrintColor);
            PrintHelper.PrintWrite("开始烤", DishContext.PrintColor);
        }
        
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
