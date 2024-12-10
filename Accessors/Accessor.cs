using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace SalesPro.Accessors
{
    public class Accessor<T> where T : BaseEntity
    {
        public async Task<T> AddAsync(T entity)
        {
            using (var _dbContext = new DatabaseContext())
            {
                _dbContext.Set<T>().Add(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
        }

        public async Task UpdateAsync<TEntity>(TEntity updatedEntity, object key) where TEntity : class
        {
            using (var _dbContext = new DatabaseContext())
            {
                var entity = await _dbContext.Set<TEntity>().FindAsync(key);
                if (entity == null)
                {
                    throw new KeyNotFoundException($"Entity of type {typeof(TEntity).Name} not found.");
                }

                var primaryKeyProperty = _dbContext.Model.FindEntityType(typeof(TEntity))
                        .FindDeclaredPrimaryKey()
                        .Properties
                        .FirstOrDefault();

                foreach (var property in _dbContext.Entry(entity).CurrentValues.Properties)
                {
                    if (property.Name == primaryKeyProperty?.Name)
                    {
                        continue;
                    }

                    _dbContext.Entry(entity).CurrentValues[property.Name] = property.PropertyInfo.GetValue(updatedEntity);
                }

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var _dbContext = new DatabaseContext())
            {
                return await _dbContext.Set<T>().FindAsync(id);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var _context = new DatabaseContext())
            {
                return await _context.Set<T>().ToListAsync();
            }
        }

        public async Task<TEntity> UpdatePartialAsync<TEntity>(int id, int rowVersion, Action<TEntity> updateAction) where TEntity : class
        {
            using (var _dbContext = new DatabaseContext())
            {
                // Fetch the entity to update
                var toUpdate = await _dbContext.Set<TEntity>().FindAsync(id);

                // Check if the entity is found
                if (toUpdate == null)
                {
                    throw new KeyNotFoundException($"{typeof(TEntity).Name} not found for id: {id}");
                }

                // Get the row version from the entity
                var currentRowVersion = (byte[])_dbContext.Entry(toUpdate).Property("RowVersion").CurrentValue;

                // Check if the provided row version matches the current row version
                if (!currentRowVersion.SequenceEqual(BitConverter.GetBytes(rowVersion)))
                {
                    throw new DbUpdateConcurrencyException("The entity has been modified by another user.");
                }

                // Apply the updates via the action
                updateAction(toUpdate);

                // Save the changes
                await _dbContext.SaveChangesAsync();

                return toUpdate;
            }
        }


    }

}
