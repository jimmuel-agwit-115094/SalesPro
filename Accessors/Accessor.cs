using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SalesPro.Accessors
{
    public class Accessor<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;

        // Constructor injection for DbContext
        public Accessor(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync<TEntity>(TEntity updatedEntity, object key) where TEntity : class
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

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllDataByIdAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<TEntity> UpdatePartialAsync<TEntity>(int id, int rowVersion, Action<TEntity> updateAction) where TEntity : class
        {
            var toUpdate = await _dbContext.Set<TEntity>().FindAsync(id);

            if (toUpdate == null)
                throw new KeyNotFoundException($"The data you are trying to update could not be found. It may have been deleted or altered.");

            var rowVersionProperty = _dbContext.Model.FindEntityType(typeof(TEntity)).FindProperty(Constants.SystemConstants.RowVersion);

            var rowVersionValue = rowVersionProperty.PropertyInfo.GetValue(toUpdate);
            if ((int)rowVersionValue != rowVersion)
                throw new DbUpdateConcurrencyException($"The data you are trying to update has been modified or deleted by another user since you last retrieved it. \n" +
                    $"Please reload the data and try again.");

            updateAction(toUpdate);
            await _dbContext.SaveChangesAsync();
            return toUpdate;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity of type {typeof(T).Name} not found.");
            }

            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
