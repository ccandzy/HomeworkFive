using System;
using HomeworkFiveBaseModel;

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
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
