﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Logic
{
    public abstract class BaseManager<T>
        where T : BaseData
    {
        protected WebShopDB _db;
        protected abstract DbSet<T> Table { get; }

        public BaseManager(WebShopDB db)
        {
            _db = db;
        }

        public T Get(int id)
        {
            return Table.FirstOrDefault( i => i.Id == id);
        }

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T Create (T data)
        {
            Table.Add(data);
            _db.SaveChanges();

            return data;
        }

        public void Update(T data)
        {
            Table.Update(data);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = Table.FirstOrDefault(i => i.Id == id);
            Table.Remove(item);

            _db.SaveChanges();
        }

        // pamatoperācijas jeb CRUD
    }
}
