using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class PigStewPowder : AbstractFood
    {
        public PigStewPowder()
        {
            Id = 4;
            Name = "猪肉炖粉条";
        }

        public override void DoDish()
        {
            Console.WriteLine("取猪肉");
            Console.WriteLine("泡粉条");
            Console.WriteLine("大火炖一小时");
        }
        
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
