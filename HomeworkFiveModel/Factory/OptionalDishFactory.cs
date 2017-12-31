using HomeworkFiveBaseModel.Config;
using HomeworkFiveModel.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HomeworkFiveBaseModel.Factory
{
    public class OptionalDishFactory
    {
        public static string CurrentPath = AppDomain.CurrentDomain.BaseDirectory;

        private static List<AbstractFood> listDish = null;
        private static List<OptionalDishConfig> optionalDish = new List<OptionalDishConfig>();

        public static List<AbstractFood> CreateDish()
        {
            listDish = new List<AbstractFood>();
            ReadJsonData();
            DishConfigConvertDish();
            return listDish;
        }

        private static void ReadJsonData()
        {
            string sJosn = File.ReadAllText(CurrentPath + "/Config/Dish.json");
            optionalDish = JsonHelper.StringToObject<List<OptionalDishConfig>>(sJosn);
        }
        
        private static void DishConfigConvertDish()
        {
            foreach (var opDish in optionalDish)
            {
                Assembly assembly = Assembly.Load(opDish.NameSpaceName);
                opDish.ClassList.ForEach(x => listDish.Add(assembly.CreateInstance(x) as AbstractFood));
            }
        }
    }
}
