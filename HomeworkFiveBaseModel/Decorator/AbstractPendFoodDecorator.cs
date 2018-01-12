using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFiveBaseModel.Decorator
{
    public class AbstractPendFoodDecorator : AbstractFoodDecorator
    {
        public AbstractPendFoodDecorator(AbstractFood abstractFood) : base(abstractFood)
        {
        }

        public override void DoDish()
        {
            base.DoDish();
            PendFood();
        }

        private void PendFood()
        {
            Console.WriteLine("摆盘");
        }
    }
}
