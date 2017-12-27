using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class BigRicePorridge : BasePorridge
    {
        public BigRicePorridge()
        {
            Id = 1;
            Name = "大米粥";
        }

        public override void Show()
        {
            Console.WriteLine($"This is {Name},推荐指数:★★★★★");
        }
    }
}
