using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationQuizz2
{
    public class UsersRepository : IRepository<User> 
    {

        Model1 _authorContext;

        public UsersRepository()
        {
            _authorContext = new Model1();

        }
        public IEnumerable<User> List
        {
            get
            {
                return _authorContext.Users;
            }

        }

        public void Add(User entity)
        {
            _authorContext.Users.Add(entity);
            _authorContext.SaveChanges();
        }

        public void Delete(int id)
        { 
            var entity = _authorContext.Users.Where(x => x.ID == id).FirstOrDefault();
            _authorContext.Users.Remove(entity);
            _authorContext.SaveChanges();
        }

        public void Update(User entity)
        {
            _authorContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _authorContext.SaveChanges();

        }

        public User FindById(int Id)
        {
            var result = (from r in _authorContext.Users where r.ID == Id select r).FirstOrDefault();
            return result;
        }

    }
}
