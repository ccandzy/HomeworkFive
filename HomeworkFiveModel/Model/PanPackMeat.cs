using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class PanPackMeat : AbstractFood
    {
        public PanPackMeat()
        {
            Id = 5;
            Name = "锅包肉";
           
        }
        public override void DoDish()
        {
            Console.WriteLine("取荷叶");
            Console.WriteLine("大火闷1小时");
        }
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
