using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveModel.Model
{
    public class HuNanSoup : BaseSoup
    {
        public HuNanSoup()
        {
            Id = 90;
            Name = "湖南汤";
        }

        public override void Show()
        {
            PrintHelper.PrintWrite($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
