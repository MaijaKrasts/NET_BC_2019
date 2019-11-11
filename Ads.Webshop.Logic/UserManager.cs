using Ads.Webshop.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsWebshop.Logic
{
    public class UserManager : BaseManager<User>
    {

        public UserManager(AdsWebShopDB db)
            : base(db)
        {
        }

        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }

        public User GetByEmail(string email)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email);

            return user;
        }

        public void Seed()
        {
            //Users.Add(new User()
            //{
            //    Id = 1,
            //    Email = "test@mail.com",
            //    Password = "pass123"
            //});
        }
    }
}
