using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Factory.AbstractFactory
{
    public class NorthEastDishFactory : DishAbstractFactory
    {
        public override AbstractFood CreateDish()
        {
            return new PigStewPowder();
        }

        public override BaseFood CreateFood()
        {
            return new Noodles();
        }

        public override AbstractFood CreateHotDish()
        {
            return new PanPackMeat();
        }

        public override BasePorridge CreatePorridge()
        {
            return new BigRicePorridge();
        }

        public override BaseSoup CreateSoup()
        {
            return new Liquor();
        }

        public override AbstractFood CreateSpicyDish()
        {
            return new ThreeFresh();
        }
    }
}
