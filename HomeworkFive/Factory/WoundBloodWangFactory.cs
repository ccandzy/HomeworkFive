using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Factory
{
    public class WoundBloodWangFactory : IFactory
    {
        public AbstractFood CreateDish()
        {
            return new WoundBloodWang();
        }
    }
}
