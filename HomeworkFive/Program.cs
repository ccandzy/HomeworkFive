using HomeworkFive.Factory;
using HomeworkFive.Factory.AbstractFactory;
using HomeworkFive.Model;
using HomeworkFive.Singleton;
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

            {
                Consumer consumer = new Consumer { Name = "湖南牙子" };
                Console.WriteLine("来了一个湖南牙子,点了一个湘菜套餐。如下:");
                DishAbstractFactory dishAbstractFactory = new HuNanDishFactory();
                dishAbstractFactory.Show();
            }

            {
                Consumer consumer = new Consumer { Name = "东北大汉" };
                Console.WriteLine("来了一个东北大汉,点了一桌东北菜。如下:");
                DishAbstractFactory dishAbstractFactory = new NorthEastDishFactory();
                dishAbstractFactory.Show();
            }

            {
                Console.WriteLine("*************输出菜单*************");
                SingletonDishMenu.CreateDishMenu().ShowDish();
                Console.WriteLine("*************静态构造函数单例输出菜单*************");
                SingletonForStaticConstructor.GetDishMenu().ShowDish();
                Console.WriteLine("*************静态字段单例输出菜单*************");
                SingletonForStaticField.GetDishMenu().ShowDish();
            }

            {
                //test
            }
            Console.ReadKey();
        }
    }
}
