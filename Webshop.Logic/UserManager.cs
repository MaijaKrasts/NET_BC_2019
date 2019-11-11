using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Logic
{
    public class UserManager : BaseManager<User>
    {

        public UserManager(WebShopDB db)
            :base(db)
        {
        }

        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }
        }

        public User GetByEmailAndPass(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }
        //public User Create(User user)
        //{
        //    _db.Users.Add(user);
        //    _db.SaveChanges();
        //    return user;
        //}

        //public User Update(User user)
        //{
        //    var currentUser = _db.Users.FirstOrDefault(u => u.Id == user.Id);
        //    currentUser.Email = user.Email;
        //    _db.SaveChanges();
        //    return currentUser;
        //}

        public User GetByEmail(string email)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email);
            return user;
        }

        //public void Delete(int id)
        //{
        //    var user = _db.Users.FirstOrDefault(u => u.Id == id);
        //    _db.Users.Remove(user);
        //    _db.SaveChanges();
        //}

        public void SeedUser()
        {
            //Users.Add(new User()
            //{
            //    Id = 11,
            //    Email = "test@testy.com",
            //    Password = "password123"
            //});
            //Users.Add(new User()
            //{
            //    Id = 22,
            //    Email = "test@testify.com",
            //    Password = "password123456"
            //});
        }
        }
}
