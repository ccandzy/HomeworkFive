﻿using HomeworkFiveBaseModel;
using System;
using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveGuangDongModel
{
    public class BakePig : AbstractFood
    {
        public BakePig()
        {
            Id = 10;
            Name = "烤乳猪";
            
        }
        public override void DoDish()
        {

        }

        public override void PointDish(DishContext pointDishContext)
        {
            Console.WriteLine($"{pointDishContext.TableNumber}桌{pointDishContext.ConsumerName}{Name}{pointDishContext.Quantity}份,口味{pointDishContext.HotType}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Id}: {Name},推荐指数:★★★★★");
        }
    }
}
