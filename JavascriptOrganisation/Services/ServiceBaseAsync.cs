using Microsoft.EntityFrameworkCore;
using ZombieParty.Models.Data;

namespace ZombieParty.Services
{
    public class ServiceBaseAsync<T> : IServiceBaseAsync<T> where T : class
    {
        protected readonly ZombiePartyDbContext _dbContext;

        public ServiceBaseAsync(ZombiePartyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task EditAsync(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached) _dbContext.Update<T>(entity);
            else _dbContext.Entry(entity).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
