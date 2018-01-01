using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class ChiliFryMeat:AbstractFood
    {
        public ChiliFryMeat()
        {
            Id = 1;
            Name = "辣椒炒肉";
        }

        public override void DoDish()
        {
            Console.WriteLine("放入肉");
            Console.WriteLine("放入辣椒");
        }
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
