using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Factory
{
    public class ChiliFryMeatFactory : IFactory
    {
        public AbstractFood CreateDish()
        {
            return new ChiliFryMeat();
        }
    }
}
