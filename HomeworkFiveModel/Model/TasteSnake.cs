using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class TasteSnake : AbstractFood
    {
        public TasteSnake()
        {
            Id = 2;
            Name = "口味蛇";
        }

        public override void DoDish()
        {
            PrintHelper.PrintWrite("去蛇皮", DishContext.PrintColor);
            PrintHelper.PrintWrite("吃蛇胆", DishContext.PrintColor);
            PrintHelper.PrintWrite("先炒再炖", DishContext.PrintColor);
        }
        
        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
