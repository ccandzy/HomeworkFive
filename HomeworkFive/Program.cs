﻿using HomeworkFive.Factory;
using HomeworkFive.Factory.AbstractFactory;
using HomeworkFive.Singleton;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveModel.Model;
using System;
using System.Collections.Generic;

namespace HomeworkFive
{
    class Program
    {
        private static int UserEnter = 0;
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

                AbstractFood baseDish = SimpleDishFactory.PointDish(1);
                DishContext pointDishContext = new DishContext()
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
                IFactory factory = DishFactoryMethod.CreateFactory(105);
                AbstractFood baseDish = factory.CreateDish();
                DishContext pointDishContext = new DishContext()
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


                Console.WriteLine("*************输入编号进行点菜，输入OK完成点菜*************");

                Consumer consumer = new Consumer { Name = "cc" };
                ConsumerContext consumerContext = new ConsumerContext
                {
                    ConsumerName = consumer.Name,
                    ConsumerTable = "001",
                    AbstractFoodList = new List<AbstractFood>()
                };
                consumer.Show(consumerContext);

                while(true)
                {
                    string userEnter = Console.ReadLine();
                    if (userEnter.ToUpper() == "OK") break;
                    if (!ValidationUserEnter(userEnter)) continue;
                    AbstractFood baseDish = SimpleDishFactory.PointDish(UserEnter);
                    DishContext pointDishContext = new DishContext()
                    {
                        ConsumerName = consumer.Name,
                        TableNumber = consumerContext.ConsumerTable,
                        Quantity = 1,
                        HotType = "特辣"
                    };
                    baseDish.PointDish(pointDishContext);
                    consumerContext.AbstractFoodList.Add(baseDish);
                }
                Console.WriteLine($"*************{consumer.Name}先生/女士,你确认你的菜单：*************");
                consumerContext.AbstractFoodList.ForEach(x => x.Show());
            }

            {
                
            }
            Console.ReadKey();
        }

        private static bool ValidationUserEnter(string sEnter)
        {
            if (!int.TryParse(sEnter, out UserEnter))
            {
                Console.WriteLine("输入字符串不正确！");
                return false;
            }
            return true;
        }
    }
}
