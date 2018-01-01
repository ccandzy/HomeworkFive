using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class ThreeFresh : AbstractFood
    {
        public ThreeFresh()
        {
            Id = 6;
            Name = "地三鲜";
        }

        public override void DoDish()
        {
            Console.WriteLine("土豆切块");
            Console.WriteLine("茄子切块");
            Console.WriteLine("豆角切块");
            Console.WriteLine("大火翻炒");
        }
        

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
