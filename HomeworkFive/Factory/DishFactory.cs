using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Factory
{
    public static class DishFactory
    {
        public static BaseDish PointDish(string dishNumber)
        {
            switch (dishNumber)
            {
                case "001":
                    return new ChiliFryMeat();
                default:
                    throw new NullReferenceException();
            }
        }
    }
}
