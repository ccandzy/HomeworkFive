using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveBaseModel.Decorator
{
    public class AbstractCutFoodDecorator : AbstractFoodDecorator
    {
        public AbstractCutFoodDecorator(AbstractFood abstractFood) : base(abstractFood)
        {
        }

        public override void DoDish()
        {
            CutFood();
            base.DoDish();
        }

        private void CutFood()
        {
            PrintHelper.PrintWrite("切菜", DishContext.PrintColor);
        }
    }
}
