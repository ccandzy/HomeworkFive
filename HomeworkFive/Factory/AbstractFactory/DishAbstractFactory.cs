using HomeworkFiveBaseModel;


namespace HomeworkFive.Factory.AbstractFactory
{
    public abstract class DishAbstractFactory
    {
        public abstract AbstractFood CreateDish();

        public abstract AbstractFood CreateHotDish();

        public abstract AbstractFood CreateSpicyDish();

        public abstract BaseFood CreateFood();

        public abstract BaseSoup CreateSoup();

        public abstract BasePorridge CreatePorridge();

        public void Show()
        {
            CreateDish().Show();
            CreateHotDish().Show();
            CreateSpicyDish().Show();
            CreateFood().Show();
            CreateSoup().Show();
            CreatePorridge().Show();
        }
    }
}
