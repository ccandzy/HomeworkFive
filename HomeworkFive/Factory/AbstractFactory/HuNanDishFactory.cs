using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Factory.AbstractFactory
{
    public class HuNanDishFactory : DishAbstractFactory
    {
        public override AbstractFood CreateDish()
        {
            return new WoundBloodWang();
        }
        public override AbstractFood CreateHotDish()
        {
            return new ChiliFryMeat();
        }
        public override AbstractFood CreateSpicyDish()
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
