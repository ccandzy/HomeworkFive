using HomeworkFiveBaseModel;
using System;

namespace HomeworkFiveModel.Model
{
    public class BigRicePorridge : BasePorridge
    {
        public BigRicePorridge()
        {
            Id = 50;
            Name = "大米粥";
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}:{Name},推荐指数:★★★★★");
        }
    }
}
