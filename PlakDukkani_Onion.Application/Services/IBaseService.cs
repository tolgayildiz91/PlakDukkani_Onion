using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Application.Services
{
    public interface IBaseService<T,T1> where T:class
    {
        void Create(T itemDTO);
        void Update(T item);
        void Delete(T item);
        List<T> GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetAll();
        T GetBy(Expression<Func<T, bool>> expression);
        bool Any(Expression<Func<T, bool>> expression);

    }
}
