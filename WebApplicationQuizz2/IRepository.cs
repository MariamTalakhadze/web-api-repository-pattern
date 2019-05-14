using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationQuizz2
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        T FindById(int Id);
    }
}
