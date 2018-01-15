using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveBaseModel.Decorator
{
    public class AbstractServingFoodDecorator : AbstractFoodDecorator
    {
        public AbstractServingFoodDecorator(AbstractFood abstractFood) : base(abstractFood)
        {
        }

        public override void DoDish()
        {
            base.DoDish();
            ServingFood();
        }

        private void ServingFood()
        {
            PrintHelper.PrintWrite("上菜",DishContext.PrintColor);
        }
    }
}
