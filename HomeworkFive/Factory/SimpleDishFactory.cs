using HomeworkFiveBaseModel;
using System.Configuration;
using System.Reflection;

namespace HomeworkFive.Factory
{
    public static class SimpleDishFactory
    {
        public static AbstractFood PointDish(int dishNumber)
        {
            string factoryName = ConfigurationManager.AppSettings[dishNumber.ToString()];
            string sNameSpace = factoryName.Split(',')[0];
            string sClass = factoryName.Split(',')[1];
            var instanceModel = Assembly.Load(sNameSpace);
            var baseDish = (AbstractFood)instanceModel.CreateInstance(sClass);
            return baseDish;
        }
    }
}
