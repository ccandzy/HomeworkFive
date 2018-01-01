using HomeworkFiveBaseModel;
using System;

namespace HomeworkFiveGuangDongModel
{
    public class WhiteCutChicken : AbstractFood
    {
        public WhiteCutChicken()
        {
            Id = 9;
            Name = "白切鸡";
        }

        public override void DoDish()
        {
            Console.WriteLine("半边鸡块");
            Console.WriteLine("均匀切好");
            Console.WriteLine("蒸50分钟");
        }
        

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
