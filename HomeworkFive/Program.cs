using HomeworkFive.Factory;
using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                BaseDish baseDish = DishFactory.PointDish("001");
                PointDishContext pointDishContext = new PointDishContext()
                {
                    ConsumerName = consumer.Name,
                    TableNumber = "001",
                    Quantity=1,
                    HotType = "特辣"
                };
                baseDish.PointDish(pointDishContext);
            }


            Console.ReadKey();
        }
    }
}
