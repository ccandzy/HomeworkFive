using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("洗菜");
        }
    }
}
