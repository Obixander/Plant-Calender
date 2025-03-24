using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);
        Task Remove(T entity);
        Task Update(T entity);
        Task<T> GetBy(int id);
        Task<T> GetBy(T entity);
    }
}
