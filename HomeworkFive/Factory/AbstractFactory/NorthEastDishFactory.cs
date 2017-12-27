using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkFive.Model;

namespace HomeworkFive.Factory.AbstractFactory
{
    public class NorthEastDishFactory : DishAbstractFactory
    {
        public override BaseDish CreateDish()
        {
            return new PigStewPowder();
        }

        public override BaseFood CreateFood()
        {
            return new Noodles();
        }

        public override BaseDish CreateHotDish()
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

        public override BaseDish CreateSpicyDish()
        {
            return new ThreeFresh();
        }
    }
}
