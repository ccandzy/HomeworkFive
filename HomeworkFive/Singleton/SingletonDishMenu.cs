using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Singleton
{
    //需要的时候才会被构造
    public class SingletonDishMenu
    {
        private static volatile DishMenu _dishMenu;
        private static object lockObject = new object();
        private SingletonDishMenu()
        {

        }
        public static DishMenu CreateDishMenu()
        {
            if(_dishMenu == null)
            {
                lock (lockObject)
                {
                    if (_dishMenu == null)
                    {
                        _dishMenu = new DishMenu();
                    }
                }
            }
            return _dishMenu;
        }
      
    }
}
