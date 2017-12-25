using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Factory
{
    public static class SimpleDishFactory
    {
        public static BaseDish PointDish(int dishNumber)
        {
            string factoryName = ConfigurationManager.AppSettings[dishNumber.ToString()];
            string sNameSpace = factoryName.Split(',')[0];
            string sClass = factoryName.Split(',')[1];
            var instanceModel = Assembly.Load(sNameSpace);
            var baseDish = (BaseDish)instanceModel.CreateInstance(sClass);
            return baseDish;
        }
    }
}
