using System;
using HomeworkFiveBaseModel;

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
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }

    }
}
