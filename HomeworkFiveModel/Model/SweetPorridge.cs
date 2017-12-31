using System;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
namespace HomeworkFiveModel.Model
{
    public class SweetPorridge:BasePorridge
    {
        public SweetPorridge()
        {
            Id = 40;
            Name = "八宝粥";
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★");
        }
    }
}
