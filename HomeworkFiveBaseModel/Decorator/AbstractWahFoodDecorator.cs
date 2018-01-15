
using HomeworkFiveBaseModel.Common;

namespace HomeworkFiveBaseModel.Decorator
{
    public class AbstractWashFoodDecorator : AbstractFoodDecorator
    {
        public AbstractWashFoodDecorator(AbstractFood abstractFood) : base(abstractFood)
        {
        }

        public override void DoDish()
        {
            WashFood();
            base.DoDish();
        }

        private void WashFood()
        {
            PrintHelper.PrintWrite("洗菜",DishContext.PrintColor);
        }
    }
}
