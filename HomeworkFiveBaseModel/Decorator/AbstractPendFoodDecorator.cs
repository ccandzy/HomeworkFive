using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFiveBaseModel.Common;

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
            PrintHelper.PrintWrite("摆盘",DishContext.PrintColor);
        }
    }
}
