using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
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
            Console.WriteLine($"This is {Name},推荐指数:★★★★");
        }
    }
}
