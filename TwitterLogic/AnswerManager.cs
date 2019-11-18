using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterLogic
{
    class AnswerManager
    {
        protected TwitterDB _db;

        public AnswerManager(TwitterDB db)
        {
            _db = db;
        }

        public Answer Get(int id)
        {
            return _db.Answers.FirstOrDefault(i => i.Id == id);
        }
        public List<Answer> GetAll()
        {
            return _db.Answers.ToList();
        }

        public void Delete(int id)
        {
            var answ = _db.Answers.FirstOrDefault(i => i.Id == id);
            _db.Remove(answ);
            _db.SaveChanges();
        }

        public Answer Create(Answer answ)
        {
            _db.Add(answ);
            _db.SaveChanges();
            return (answ);
        }
    }
}
