using Microsoft.EntityFrameworkCore;
using PlakDukkani_Onion.Domain.Entities.Abstract;
using PlakDukkani_Onion.Domain.Enums;
using PlakDukkani_Onion.Domain.Repositories;
using PlakDukkani_Onion.Infastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Infastructure.RepositoryConcrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly PlakDukkaniDbContext _dbContext;
        protected DbSet<T> _table;
        public BaseRepository(PlakDukkaniDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }



        public void Add(T item)
        {
            _table.Add(item);
             Save();
           
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Delete(T item)
        {
            item.Status = Status.Deleted;
            Update(item);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetBy(Expression<Func<T, bool>> expression)
        {
            return  _table.Where(expression).FirstOrDefault();
        }

        public List<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T item)
        {
            _dbContext.Entry<T>(item).State = EntityState.Modified;
            Save();
        }

        public int Save()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
