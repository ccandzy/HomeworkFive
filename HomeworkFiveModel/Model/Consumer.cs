

using HomeworkFiveBaseModel.Context;

namespace HomeworkFiveModel.Model
{
    public class Consumer
    {
        public string Name { get;set; }

        public void Show(ConsumerContext consumerContext)
        {
            System.Console.WriteLine($"{consumerContext.ConsumerTable}桌,{consumerContext.ConsumerName}先生/女士,客人一共{consumerContext.CumsummerNumber}位");
        }
    }
}
