using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeneriqueCRUD.Services
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> IsExistsAsync(int id);
    }
}
