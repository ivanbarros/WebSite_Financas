using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IRepositoryBase<T,TContext> 
        where T : class 
        where TContext : DbContext
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        IEnumerable<T> GetByEmail(string username, string password);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
