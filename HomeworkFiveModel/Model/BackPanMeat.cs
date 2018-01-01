using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class BackPanMeat : AbstractFood
    {
        public BackPanMeat()
        {
            Id = 7;
            Name = "回锅肉";
        }

        public override void DoDish()
        {
            Console.WriteLine("取肥肉");
            Console.WriteLine("油炸");
            Console.WriteLine("回锅");
        }
        
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
