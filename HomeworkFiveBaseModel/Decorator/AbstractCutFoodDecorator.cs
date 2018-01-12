using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("切菜");
        }
    }
}
