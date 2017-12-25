using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Factory
{
    public interface IFactory
    {
        BaseDish CreateDish();
    }
}
