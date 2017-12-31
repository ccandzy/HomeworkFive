using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

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
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
