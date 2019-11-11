using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Webshop.Logic.Tests
{
    [TestClass]
    public class CategoryUnitTest3
    {
        [TestMethod]
        public void TestGetAllCategory()
        {
            CategoryManager manager = new CategoryManager();
            manager.SeedCategory();

            var result = manager.GetAll();

            Assert.AreEqual("Cat1", result[0].Title);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestGetCategory()
        {
            CategoryManager manager = new CategoryManager();
            manager.SeedCategory();

            Category cat1 = manager.Get(13);
            Category cat2 = manager.Get(12);
            Category cat3 = manager.Get(1);

            Assert.AreEqual("Cat1", cat1.Title);
            Assert.AreEqual("Cat2", cat2.Title);
            Assert.IsNull(cat3);
        }

    }
}
