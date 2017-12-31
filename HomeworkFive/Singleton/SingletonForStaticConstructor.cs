using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Singleton
{
    //会直接构造 只要调用就会一直存在
    public class SingletonForStaticConstructor
    {
        private static DishMenu _dishMenu;
        static SingletonForStaticConstructor()
        {
            _dishMenu = new DishMenu();
        }
        public static DishMenu GetDishMenu()
        {
            return _dishMenu;
        }
    }
}
