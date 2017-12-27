using HomeworkFive.Model;

namespace HomeworkFive.Factory.AbstractFactory
{
    public class HuNanDishFactory : DishAbstractFactory
    {
        public override BaseDish CreateDish()
        {
            return new WoundBloodWang();
        }
        public override BaseDish CreateHotDish()
        {
            return new ChiliFryMeat();
        }
        public override BaseDish CreateSpicyDish()
        {
            return new TasteSnake();
        }
        public override BaseFood CreateFood()
        {
            return new Rice();
        }
        public override BaseSoup CreateSoup()
        {
            return new HuNanSoup();
        }

        public override BasePorridge CreatePorridge()
        {
            return new SweetPorridge();
        }
    }
}
