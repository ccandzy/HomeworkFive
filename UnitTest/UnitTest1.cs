
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using HomeworkFive.Singleton;
using System.Collections.Generic;
using System.IO;
using HomeworkFiveModel.Model;
using HomeworkFiveBaseModel;
using HomeworkFiveBaseModel.Config;
using HomeworkFiveBaseModel.Factory;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSingleton()
        {
            TaskFactory taskFactory = new TaskFactory();
            List<Task> taskList = new List<Task>();
            for (int i = 0; i < 5000; i++)
            {
                taskList.Add(taskFactory.StartNew(() =>
                {
                    SingletonDishMenu.CreateDishMenu().Show();
                }));
            }
            Task.WaitAll(taskList.ToArray());
            Assert.AreEqual(5000, SingletonDishMenu.CreateDishMenu().i);
        }
        [TestMethod]
        public void TestSingletonDish()
        {
            Assert.AreEqual(SingletonDishMenu.CreateDishMenu(), SingletonDishMenu.CreateDishMenu());
        }

        [TestMethod]
        public void TestSingletonStaticConstructor()
        {
            SingletonForStaticConstructor.GetDishMenu();
            Assert.AreEqual(SingletonForStaticConstructor.GetDishMenu(), SingletonForStaticConstructor.GetDishMenu());
        }

        [TestMethod]
        public void TestReadJsonConfig()
        {
            var sJson = File.ReadAllText(OptionalDishFactory.CurrentPath + @"\Config\Dish.json");
            List<OptionalDishConfig> listBaseDish = JsonHelper.StringToObject<List<OptionalDishConfig>>(sJson);
            Assert.AreEqual(1, listBaseDish.Count);
            Assert.AreEqual(2, listBaseDish[0].ClassList.Count);
        }

        [TestMethod]
        public void TestWriteJson()
        {
            List<OptionalDishConfig> opDishList = new List<OptionalDishConfig>
            {
                new OptionalDishConfig{NameSpaceName="testName",ClassList=new List<string>{ "1","2"} }
            };

            var sJosn = JsonHelper.ObjectToString(opDishList);
        }
        [TestMethod]
        public void TestOptionalDishFactory()
        {
            List<AbstractFood> opDishList = OptionalDishFactory.CreateDish();
            Assert.AreEqual(2, opDishList.Count);
        }
    }
}
