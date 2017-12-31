
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Factory;
using System.Collections.Generic;

namespace HomeworkFiveModel.Model
{
    public class DishMenu
    {
      
        private object lockObject = new object();
        private List<AbstractFood> _baseDishs = new List<AbstractFood>();

        public int i = 0;
        public List<AbstractFood> DishMenus { get { return _baseDishs; } }

        public DishMenu()
        {
            _baseDishs.Add(new ChiliFryMeat());
            _baseDishs.Add(new TasteSnake());
            _baseDishs.Add(new WoundBloodWang());
            _baseDishs.Add(new PigStewPowder());
            _baseDishs.Add(new PanPackMeat());
            _baseDishs.Add(new ThreeFresh());

            _baseDishs.AddRange(OptionalDishFactory.CreateDish());
        }

        public void ShowDish()
        {
            _baseDishs.ForEach(x => x.Show());
        }

        
        public void Show()
        {
            lock (lockObject)
            {
                i++;
            }
        }
    }
}
