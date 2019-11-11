using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Webshop.Logic.Tests
{
    [TestClass]
    public class ItemUnitTest
    {
        [TestMethod]
        public void TestCreateItem()
        {
            ItemManager manager = new ItemManager();
            Item item = manager.Create(new Item()
            {
                Price = 1000,
                Description = "gooddescription",
                Title = "goodtitle",
                Photo="good photo",
                CategoryId = 1

            });

            Assert.AreEqual("gooddescription", item.Description);
            Assert.AreEqual("goodtitle", item.Title);
            Assert.AreEqual("good photo", item.Photo);
            Assert.AreEqual(1, item.CategoryId);
            Assert.AreEqual(1000, item.Price);
        }

        [TestMethod]
        public void TestGetItem()
        {
            ItemManager manager = new ItemManager();
            manager.SeedItem();

            Item item1 = manager.Get(1);
            Item item2 = manager.Get(2);
            Item item3 = manager.Get(3);

            Assert.AreEqual("Item1", item1.Title);
            Assert.AreEqual("Item2", item2.Title);
            Assert.IsNull(item3);
        }

        [TestMethod]
        public void TestUpdateItem()
        {
            ItemManager manager = new ItemManager();
            manager.SeedItem();

            manager.Update(new Item()
            {
                Id = 1,
                Price = 1000,
                Description = "gooddescription",
                Title = "goodtitle",
                Photo = "good photo",
                CategoryId = 1
            });

            var item = manager.Get(1);

            Assert.AreEqual(1, item.Id);
            Assert.AreEqual("gooddescription", item.Description);
            Assert.AreEqual("goodtitle", item.Title);
            Assert.AreEqual("good photo", item.Photo);
            Assert.AreEqual(1000, item.Price);
        }

        [TestMethod]
        public void TestDeleteItem()
        {
            ItemManager manager = new ItemManager();
            manager.SeedItem();

            manager.Delete(1);

            var deleteUser = manager.Get(1);

            Assert.IsNull(deleteUser);
        }

        [TestMethod]
        public void TestGetItemByCategory()
        {
            ItemManager manager = new ItemManager();
            manager.SeedItem();

            var result = manager.GetByCategory(13);
            var result2 = manager.GetByCategory(45);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(0, result2.Count);
        }
    }
}
