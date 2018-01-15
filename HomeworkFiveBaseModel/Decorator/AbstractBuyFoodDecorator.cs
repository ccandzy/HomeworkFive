using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveBaseModel
{
    public class AbstractBuyFoodDecorator : AbstractFoodDecorator
    {
        public AbstractBuyFoodDecorator(AbstractFood abstractFood) : base(abstractFood)
        {
        }

        public override void DoDish()
        {
            BuyFood();
            base.DoDish();
        }

        public void BuyFood()
        {
            PrintHelper.PrintWrite("买菜",DishContext.PrintColor);
        }
    }
}
