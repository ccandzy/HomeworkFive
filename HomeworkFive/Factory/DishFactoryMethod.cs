﻿using HomeworkFive.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFive.Factory
{
    public static class DishFactoryMethod
    {
        public static IFactory CreateFactory(int dishNumber)
        {
            string factoryName = ConfigurationManager.AppSettings[dishNumber.ToString()];
            string sNameSpace = factoryName.Split(',')[0];
            string sClass = factoryName.Split(',')[1];
            var instanceModel = Assembly.Load(sNameSpace);
            var factory = (IFactory)instanceModel.CreateInstance(sClass);
            return factory;
        }
    }
}
