using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T>(DataContext context) : IGenericRepository<T> where T : class
    {
        public void Add(T entity) 
        {
            throw new NotImplementedException();    
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public T GetBy(T entity)
        {
            throw new NotImplementedException();
        }


    }
}
