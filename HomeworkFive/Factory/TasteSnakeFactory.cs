using HomeworkFiveBaseModel;
using HomeworkFiveModel.Model;

namespace HomeworkFive.Factory
{
    public class TasteSnakeFactory : IFactory
    {
        public AbstractFood CreateDish()
        {
            return new TasteSnake();
        }
    }
}
