using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetBy(int id);
        T GetBy(T entity);
    }
}
