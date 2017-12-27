using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Factory.AbstractFactory
{
    public abstract class DishAbstractFactory
    {
        public abstract BaseDish CreateDish();

        public abstract BaseDish CreateHotDish();

        public abstract BaseDish CreateSpicyDish();

        public abstract BaseFood CreateFood();

        public abstract BaseSoup CreateSoup();

        public abstract BasePorridge CreatePorridge();

        public void Show()
        {
            CreateDish().Show();
            CreateHotDish().Show();
            CreateSpicyDish().Show();
            CreateFood().Show();
            CreateSoup().Show();
            CreatePorridge().Show();
        }
    }
}
