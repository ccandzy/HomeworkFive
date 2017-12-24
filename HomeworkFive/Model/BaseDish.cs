using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Model
{
    public abstract class BaseDish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Show();
        public abstract void PointDish(PointDishContext pointDishContext);
    }
}
