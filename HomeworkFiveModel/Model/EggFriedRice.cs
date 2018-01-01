using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class EggFriedRice : AbstractFood
    {
        public EggFriedRice()
        {
            Id = 8;
            Name = "蛋炒饭";
        }

        public override void DoDish()
        {
            Console.WriteLine("取冷饭");
            Console.WriteLine("炒鸡蛋");
            Console.WriteLine("倒入饭");
        }
        
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
