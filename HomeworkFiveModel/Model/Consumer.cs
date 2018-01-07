

using HomeworkFiveBaseModel.Common;
using HomeworkFiveBaseModel.Context;
using System;

namespace HomeworkFiveModel.Model
{
    public class Consumer
    {
        public ConsoleColor PrintColor { get; set; }

        public string Name { get;set; }

        public ConsumerContext ConsumerContext { get; set; }

        public void Show(ConsumerContext consumerContext)
        {
            ConsumerContext = consumerContext;
            PrintHelper.PrintWrite($"{consumerContext.ConsumerTable}桌,{consumerContext.ConsumerName}先生/女士,客人一共{consumerContext.CumsummerNumber}位",PrintColor);
        }
    }
}
