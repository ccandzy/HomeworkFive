using System;
using System.Threading.Tasks;
using log4net;
using System.Collections.Generic;
using HomeworkFiveModel.Model;
using HomeworkFive.Helper;
using HomeworkFiveBaseModel;
using HomeworkFive.Factory;
using HomeworkFiveBaseModel.Context;
using HomeworkFive.Factory.AbstractFactory;
using HomeworkFive.Singleton;

namespace HomeworkFive
{
    class Program
    {
       
        private static int UserEnter = 0;
        static void Main(string[] args)
        {
            {
                #region 1  每个人要学会做几个菜，不低于3个。。。先不用任何工厂方法，普通实现，分别展示几个菜，好不好吃

                Console.WriteLine("1 每个人要学会做几个菜，不低于3个。。。先不用任何工厂方法，普通实现，分别展示几个菜，好不好吃");

                ChiliFryMeat chiliFryMeat = new ChiliFryMeat();
                chiliFryMeat.Show();
                TasteSnake tasteSnake = new TasteSnake();
                tasteSnake.Show();
                WoundBloodWang woundBloodWang = new WoundBloodWang();
                woundBloodWang.Show();
                #endregion
            }

            {
                #region 2 用简单工厂实现客人点菜，而不是让客人自己做菜(文字说明：如果要加一个菜，需要修改什么，考虑下简单工厂的长处和短处)
                Console.WriteLine();
                Console.WriteLine("2 用简单工厂实现客人点菜，而不是让客人自己做菜");
                Consumer consumer = new Consumer { Name ="张山"};
                AbstractFood baseDish = SimpleDishFactory.PointDish(1);
                DishContext pointDishContext = new DishContext()
                {
                    ConsumerName = consumer.Name,
                    TableNumber = "001",
                    Quantity = 1,
                    HotType = "特辣"
                };
                baseDish.PointDish(pointDishContext);

                #endregion 
                //简单工厂长处：上层不再负责创建细节，把细节交给工厂，上层调用简单
                //简单工厂短处：1.工厂内部复杂性增加，耦合.
                //              2.新增菜品，如果不通过反射则必须修改原来的工厂类，破坏封装

            }

            {
                #region 3  用工厂方法实现客人点菜，而不是让客人自己做菜
                Console.WriteLine();
                Console.WriteLine("3  用工厂方法实现客人点菜，而不是让客人自己做菜");
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
                #endregion
                //工厂方法长处：1.工厂内部不再封装全部细节，解决了简单工厂的耦合问题 。
                //              2.创建新的菜品，不再需要修改原来的工厂。对修改封闭
                //工厂方法短处：1.代码麻烦，一个类一个工厂.
                //              2.新增菜品，必须新增一个类和他对应的工厂
            }

            #region 4  用抽象工厂，每个工厂都能做三个菜、一个汤、一个主食
            Console.WriteLine();
            Console.WriteLine("4  用抽象工厂，每个工厂都能做三个菜、一个汤、一个主食");
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
            #endregion
            //抽象工厂长处：1.不再一个类对应一个工厂，而是按规则对应一组类，解决了工厂方法工厂过多的问题。。
            //              2.创建新的菜品，不再需要修改原来的工厂。对修改封闭
            //抽象工厂短处：1.当规则改变时,则修改较麻烦
            //              2.并不是全部的对修改封闭

            #region 5  做个点菜系统，用户输入可选菜id进行点菜：
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("4  做个点菜系统，用户输入可选菜id进行点菜");
                Console.WriteLine("*************输出菜单*************");
                SingletonDishMenu.CreateDishMenu().ShowDish();
                //Console.WriteLine("*************静态构造函数单例输出菜单*************");
                //SingletonForStaticConstructor.GetDishMenu().ShowDish();
                //Console.WriteLine("*************静态字段单例输出菜单*************");
                //SingletonForStaticField.GetDishMenu().ShowDish();


                Console.WriteLine("*************输入编号进行点菜，输入OK完成点菜*************");

                Consumer consumer = new Consumer { Name = "cc" };
                ConsumerContext consumerContext = new ConsumerContext
                {
                    ConsumerName = consumer.Name,
                    ConsumerTable = "001",
                    CumsummerNumber = 2,
                    AbstractFoodList = new List<AbstractFood>()
                };
                consumer.Show(consumerContext);

                while (true)
                {
                    string userEnter = Console.ReadLine();
                    if (userEnter.ToUpper() == "OK") break;
                    if (!ValidationHelper.ValidationUserEnter(userEnter, out UserEnter)) continue;
                    AbstractFood baseDish = SimpleDishFactory.PointDish(UserEnter);
                    if (baseDish == null) { Console.WriteLine("输入的编号不存在，请从新输入"); }continue;
                    DishContext pointDishContext = new DishContext()
                    {
                        Id = baseDish.Id,
                        ConsumerName = consumer.Name,
                        TableNumber = consumerContext.ConsumerTable,
                        Quantity = 1,
                        HotType = "特辣"
                    };
                    baseDish.PointDish(pointDishContext);
                    consumerContext.AbstractFoodList.Add(baseDish);
                }
                Console.WriteLine($"*************{consumer.Name}先生/女士,你确认你的菜单：*************");
                consumerContext.AbstractFoodList.ForEach(x => x.ConsumerConfirmDish());
            }
            #endregion

            #region f)多线程演示：甲乙丙三个客人(三个线程)分别随机点5个菜，然后每个菜依次做菜、品尝、点评，最高的菜，展示出来 三个客人都吃完后，评选出得分最高的菜，展示出来
            {
                TaskFactory taskFactory = new TaskFactory();
                List<Task> taskList = new List<Task>();
                List<Consumer> consumerList = new List<Consumer>();

                Consumer consumerO = new Consumer { Name = "面向对象", PrintColor = ConsoleColor.DarkCyan };
                consumerList.Add(consumerO);
                taskList.Add(taskFactory.StartNew(() => { ConsumerHelper.ConsumerIsComing(consumerO); }));

                Consumer consumerA = new Consumer { Name = "面向抽象", PrintColor = ConsoleColor.Blue };
                consumerList.Add(consumerA);
                taskList.Add(taskFactory.StartNew(() => { ConsumerHelper.ConsumerIsComing(consumerA); }));

                Consumer consumerB = new Consumer { Name = "面向过程", PrintColor = ConsoleColor.Cyan };
                consumerList.Add(consumerB);
                taskList.Add(taskFactory.StartNew(() => { ConsumerHelper.ConsumerIsComing(consumerB); }));

                taskFactory.ContinueWhenAll(taskList.ToArray(), (x) =>
                {
                    ConsumerHelper.PrintMostHighFood(consumerList);
                });
            }
            #endregion

            Console.ReadKey();
        }
    }
}
