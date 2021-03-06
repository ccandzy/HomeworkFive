﻿using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Singleton
{ 
    //会直接构造 只要调用就会一直存在
    public class SingletonForStaticField
    {
        private static DishMenu _dishMenu = new DishMenu();
        private SingletonForStaticField()
        {
        }
        public static DishMenu GetDishMenu()
        {
            return _dishMenu;
        }
    }
}
