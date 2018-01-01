using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
namespace HomeworkFiveModel.Model
{
    public class TasteSnake : AbstractFood
    {
        public TasteSnake()
        {
            Id = 2;
            Name = "口味蛇";
        }

        public override void DoDish()
        {
            Console.WriteLine("去蛇皮");
            Console.WriteLine("吃蛇胆");
            Console.WriteLine("先炒再炖");
        }
        
        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
