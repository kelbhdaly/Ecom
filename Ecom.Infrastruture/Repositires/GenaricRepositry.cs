using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Infrastruture.Repositires
{
    public class GenaricRepositry<T> : IGenaricRepositry<T> where T : class
    {
        private readonly AppDbContext _dbContext;

        public GenaricRepositry(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(T entity) => await _dbContext.Set<T>().AddAsync(entity);


        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync() => await _dbContext.Set<T>().AsNoTracking().ToListAsync();


        public async Task<IReadOnlyList<T>> GetAllAsync(params System.Linq.Expressions.Expression<Func<T, object>>[] include)
        {
            var query = _dbContext.Set<T>().AsQueryable();

            foreach (var item in include)
            {
                query = query.Include(item);

            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public Task<T> GetByIdAsync(int id, params System.Linq.Expressions.Expression<Func<T, object>>[] include)
        {
            var query = _dbContext.Set<T>().AsQueryable();
            foreach (var item in include)
            {
                query = query.Include(item);

            }
            var entity = query.FirstOrDefaultAsync(x => EF.Property<int>(x, "id") == id);
            return entity;
        }
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
           await  _dbContext.SaveChangesAsync();
        }
    }
}
