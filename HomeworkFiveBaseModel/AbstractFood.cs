using HomeworkFiveBaseModel.Common;
using HomeworkFiveBaseModel.Context;
using System;

namespace HomeworkFiveBaseModel
{
    public abstract class AbstractFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Introduction { get; set; }

        public DishContext DishContext { get; private set; }
        public void Taste()
        {
            PrintHelper.PrintWrite("品尝", DishContext.PrintColor);
        }

        public virtual void Review()
        {
            var review = new RandomHelper().GetNumber(0, 20);
            PrintHelper.PrintWrite($"{Name}获得{review}分",DishContext.PrintColor );
            DishContext.Review = review;
        }

        public abstract void DoDish();
        public abstract void Show();
        public void PointDish(DishContext pointDishContext)
        {
            DishContext = pointDishContext;
            PrintHelper.PrintWrite($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}", DishContext.PrintColor);
        }

        public void ConsumerConfirmDish()
        {
            PrintHelper.PrintWrite($"{Name}{DishContext.Quantity}份,口味{DishContext.HotType}", DishContext.PrintColor);
        }
    }
}
