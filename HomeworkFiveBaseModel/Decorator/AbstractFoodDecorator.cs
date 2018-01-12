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
            this.Id = abstractFood.Id;
            this.Name = abstractFood.Name;
            this.Introduction = abstractFood.Introduction;
            this.Price = abstractFood.Price;
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
