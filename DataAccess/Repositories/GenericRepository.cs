using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    /// <summary>
    /// A generic repository for performing CRUD operations on entities.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public class GenericRepository<T>(DataContext context) : IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Adds a new entity to the context and saves changes.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public async Task Add(T entity)
        {
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes an entity from the context and saves changes.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        public async Task Remove(T entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates an existing entity in the context and saves changes.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public async Task Update(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Retrieves an entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity.</param>
        /// <returns>The entity if found; otherwise, throws a NullReferenceException.</returns>
        public async Task<T> GetBy(int id)
        {
            var result = await context.FindAsync<T>(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Retrieves an entity by its instance.
        /// </summary>
        /// <param name="entity">The instance of the entity.</param>
        /// <returns>The entity if found; otherwise, throws a NullReferenceException.</returns>
        public async Task<T> GetBy(T entity)
        {
            var result = await context.FindAsync<T>(entity);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
