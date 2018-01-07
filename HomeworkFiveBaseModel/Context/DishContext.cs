

using System;

namespace HomeworkFiveBaseModel.Context
{
    public class DishContext   
    {
        public int Id { get; set; }
        public string ConsumerName { get; set; }
        public string TableNumber { get; set; }
        public string HotType { get; set; }
        public int Quantity { get; set; }
        public ConsoleColor PrintColor { get; set; }
        public int Review { get; set; }
    }
}
