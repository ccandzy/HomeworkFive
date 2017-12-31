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

        public void Taste()
        {
            Console.WriteLine("品尝");
        }

        public virtual void Review()
        {
            Console.WriteLine("好评");
        }

        public abstract void DoDish();
        public abstract void Show();
        public abstract void PointDish(DishContext pointDishContext);
    }
}
