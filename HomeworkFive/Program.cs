using HomeworkFive.Factory;
using HomeworkFive.Model;
using System;

namespace HomeworkFive
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                #region 步骤1
                ChiliFryMeat chiliFryMeat = new ChiliFryMeat();
                chiliFryMeat.Show();
                TasteSnake tasteSnake = new TasteSnake();
                tasteSnake.Show();
                WoundBloodWang woundBloodWang = new WoundBloodWang();
                woundBloodWang.Show();
                #endregion
            }
            {
                Consumer consumer = new Consumer { Name ="张山"};

                BaseDish baseDish = SimpleDishFactory.PointDish(1);
                PointDishContext pointDishContext = new PointDishContext()
                {
                    ConsumerName = consumer.Name,
                    TableNumber = "001",
                    Quantity=1,
                    HotType = "特辣"
                };
                baseDish.PointDish(pointDishContext);
            }

            {
                Consumer consumer = new Consumer { Name = "李四" };
                IFactory factory = DishFactoryMethod.CreateFactory(5);
                BaseDish baseDish = factory.CreateDish();
                PointDishContext pointDishContext = new PointDishContext()
                {
                    ConsumerName = consumer.Name,
                    TableNumber = "002",
                    Quantity = 2,
                    HotType = "中辣"
                };
                baseDish.PointDish(pointDishContext);
            }


            Console.ReadKey();
        }
    }
}
