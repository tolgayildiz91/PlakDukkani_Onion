using PlakDukkani_Onion.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Domain.Repositories
{
    public interface IBaseRepository<T> where T:IBaseEntity
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetDefault(Expression<Func<T, bool>> expression);
        T GetBy(Expression<Func<T, bool>> expression);
        bool Any(Expression<Func<T, bool>> expression);
        List<T> GetAll();

    }
}
