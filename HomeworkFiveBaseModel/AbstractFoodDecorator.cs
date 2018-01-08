using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFiveBaseModel
{
    public class AbstractFoodDecorator : AbstractFood
    {
        private AbstractFood _abstractFood;

        public AbstractFoodDecorator(AbstractFood abstractFood)
        {
            _abstractFood = abstractFood;
            DishContext =abstractFood.DishContext;
        }

        public override void DoDish()
        {
            _abstractFood.DoDish();
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
