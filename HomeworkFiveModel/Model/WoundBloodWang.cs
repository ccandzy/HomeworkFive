using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class WoundBloodWang : AbstractFood
    {
        public WoundBloodWang()
        {
            Id = 3;
            Name = "毛血旺";
        }

        public override void DoDish()
        {
            Console.WriteLine("取猪血");
            Console.WriteLine("油炸");
            Console.WriteLine("上火锅");
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
