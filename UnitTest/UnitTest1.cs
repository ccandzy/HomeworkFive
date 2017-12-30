using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using HomeworkFive.Singleton;
using System.Collections.Generic;

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
    }
}
