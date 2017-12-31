using System;
using HomeworkFiveBaseModel;

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
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
