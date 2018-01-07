using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;
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
            PrintHelper.PrintWrite($"{Id}:{Name},推荐指数:★★★★★");
        }
    }
}
