using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class Noodles:BaseFood
    {
        public Noodles()
        {
            Id = 61;
            Name = "面条";
        }

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
