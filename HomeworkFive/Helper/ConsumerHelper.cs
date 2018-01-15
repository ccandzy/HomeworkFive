using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFive.Factory;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Common;
using HomeworkFiveBaseModel.Context;
using HomeworkFiveBaseModel.Decorator;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Helper
{
    public class ConsumerHelper
    {
        public static void ConsumerIsComing(Consumer consumer)
        {
            ConsumerContext consumerContext = new ConsumerContext { ConsumerName = consumer.Name };
            consumer.Show(consumerContext);
            for (int i = 0; i < 5; i++)
            {
                AbstractFood abstractFood = CreateFood(consumer);
                consumerContext.AbstractFoodList.Add(abstractFood);
            }
            PrintResult(consumer);
        }

        private static AbstractFood CreateFood(Consumer consumer)
        {
            Console.WriteLine();
            AbstractFood abstractFood = SimpleDishFactory.PointDish(new RandomHelper().GetNumber(1, 10));
            abstractFood.PointDish(new DishContext { Id = abstractFood.Id, ConsumerName = consumer.Name, Quantity = 1, TableNumber = "002", HotType = "正常", PrintColor = consumer.PrintColor });
            abstractFood = new AbstractCutFoodDecorator(abstractFood);
            abstractFood = new AbstractWashFoodDecorator(abstractFood);
            abstractFood = new AbstractBuyFoodDecorator(abstractFood);
            abstractFood = new AbstractPendFoodDecorator(abstractFood);
            abstractFood = new AbstractServingFoodDecorator(abstractFood);
            abstractFood.DoDish();
            abstractFood.Taste();
            abstractFood.Review();
            return abstractFood;
        }

        private static void PrintResult(Consumer consumer)
        {
            var reviewList = consumer.ConsumerContext.AbstractFoodList.OrderByDescending(x => x.DishContext.Review).ToList();
            PrintHelper.PrintWrite($"{consumer.Name}认为最好吃的菜是{reviewList[0].Name}", consumer.PrintColor);
            PrintHelper.PrintWrite($"{consumer.Name}认为最难吃的菜是{reviewList[reviewList.Count - 1].Name}", consumer.PrintColor);
        }

        public static void PrintMostHighFood(List<Consumer> consumerList)
        {
            List<AbstractFood> listAbstractFood = new List<AbstractFood>();
            foreach (var consumer in consumerList)
            {
                AbstractFood abstractFood = consumer.ConsumerContext.AbstractFoodList.OrderByDescending(z => z.DishContext.Review).ToList()[0];
                listAbstractFood.Add(abstractFood);
            }
            listAbstractFood.OrderByDescending(y => y.DishContext.Review).ToList();
            PrintHelper.PrintWrite($"客人评分最高的菜是{listAbstractFood[0].Name}", ConsoleColor.Red);
        }
    }
}
