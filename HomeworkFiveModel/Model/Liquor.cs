using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class Liquor:BaseSoup
    {
        public Liquor()
        {
            Id = 91;
            Name = "白酒汤";
        }


        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }

    }
}
