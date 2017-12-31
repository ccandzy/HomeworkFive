using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFiveBaseModel.Context
{
    public class ConsumerContext
    {
        public string ConsumerTable { get; set; }
        public string ConsumerName { get; set; }
        public int CumsummerNumber { get; set; }
        public List<AbstractFood> AbstractFoodList { get; set; }

    }
}
