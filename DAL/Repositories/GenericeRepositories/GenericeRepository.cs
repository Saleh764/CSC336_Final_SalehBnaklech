using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.GenericeRepositories;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.GenericeRepository
{
    public class GenericeRepository<T> : IGenericeRepository<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly DbContext _dbContext;

        public GenericeRepository( DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
            
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return entity;
        }

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        #endregion

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _dbContext.SaveChanges();
            }
            catch
            {

            }
            return entity;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            else
            {
                return false;
            }
        }

    }
}
