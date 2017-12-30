using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public class DishMenu
    {
      
        private object lockObject = new object();
        private List<BaseDish> _baseDishs = new List<BaseDish>();

        public int i = 0;
        public List<BaseDish> DishMenus { get { return _baseDishs; } }

        public DishMenu()
        {
            _baseDishs.Add(new ChiliFryMeat());
            _baseDishs.Add(new TasteSnake());
            _baseDishs.Add(new WoundBloodWang());
            _baseDishs.Add(new PigStewPowder());
            _baseDishs.Add(new PanPackMeat());
            _baseDishs.Add(new ThreeFresh());
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
