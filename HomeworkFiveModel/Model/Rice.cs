using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class Rice:BaseFood
    {
        public Rice()
        {
            Id = 30;
            Name = "米饭";
        }

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
