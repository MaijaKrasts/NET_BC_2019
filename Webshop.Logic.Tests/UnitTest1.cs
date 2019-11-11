using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Webshop.Logic.Tests
{
    [TestClass]
    public class UserUnitTest
    {
        //user:
        [TestMethod]

        public void TestCreateuser()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "testest@testest.com",
                Password = "goodpass"
            });

            Assert.AreEqual("testest@testest.com", user.Email);
            Assert.IsTrue(user.Id > 0);
        }

        [TestMethod]
        public void TestGetByEmailAndPass()
        {
            UserManager manager = new UserManager();
            manager.SeedUser();

            User user1 = manager.GetByEmailAndPass("test@testy.com", "password123");
            User user2 = manager.GetByEmailAndPass("test@t.com", "password");
            User user3 = manager.GetByEmailAndPass("test@testify.com", "pass");

            Assert.AreEqual("test@testy.com", user1.Email);
            Assert.IsNull(user2);
            Assert.IsNull(user3);
        }

        [TestMethod]
        public void TestUpdate()
        {
            UserManager manager = new UserManager();
            manager.SeedUser();

            manager.Update(new User()
            {
                Id = 11,
                Email = "updateemail@test.com"
            });

            var user = manager.GetByEmailAndPass("updateemail@test.com", "password123");
            Assert.AreEqual(11, user.Id);
            Assert.AreEqual("updateemail@test.com", user.Email);
        }

        [TestMethod]
        public void TestGetByEmail()
        {
            UserManager manager = new UserManager();
            manager.SeedUser();

            User user1 = manager.GetByEmail("test@testy.com");
            User user2 = manager.GetByEmail("test@t.com");

            Assert.AreEqual("test@testy.com", user1.Email);
            Assert.IsNull(user2);

        }

        [TestMethod]
        public void TestDelete()
        {
            UserManager manager = new UserManager();
            manager.SeedUser();

            manager.Delete(11);

            var deleteUser = manager.GetByEmail("test@testy.com");

            Assert.IsNull(deleteUser);
        }
    }
}
