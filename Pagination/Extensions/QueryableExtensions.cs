using Microsoft.EntityFrameworkCore;
using Pagination.Models;

namespace Pagination.Extensions
{
    public static class QueryableExtensions
    {
        public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int pageNumber, int pageSize) where T : class
        {
            var result = new PagedResult<T>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = await query.CountAsync()
            };

            result.Items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return result;
        }
    }

}
