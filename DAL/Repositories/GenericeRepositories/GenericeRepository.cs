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
        public readonly DbContext dbContext;
    }
}
