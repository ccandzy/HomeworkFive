using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveGuangDongModel
{
    public class BakePig : AbstractFood
    {
        public BakePig()
        {
            Id = 10;
            Name = "烤乳猪";
            
        }
        public override void DoDish()
        {
            Console.WriteLine("取整猪");
            Console.WriteLine("木材烧火");
            Console.WriteLine("开始烤");
        }
        
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
