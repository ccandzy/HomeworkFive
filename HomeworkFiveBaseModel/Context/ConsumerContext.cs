
using System.Collections.Generic;


namespace HomeworkFiveBaseModel.Context
{
    public class ConsumerContext
    {
        public ConsumerContext()
        {
            AbstractFoodList = new List<AbstractFood>();
        }
        public string ConsumerTable { get; set; }
        public string ConsumerName { get; set; }
        public int CumsummerNumber { get; set; }
        public List<AbstractFood> AbstractFoodList { get; set; }

    }
}
