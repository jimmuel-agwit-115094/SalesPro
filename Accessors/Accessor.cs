using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesPro.Accessors
{
    public class Accessor<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;
        public Accessor(DatabaseContext context)
        {
            _dbContext = context;
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
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var _context = new DatabaseContext())
            {
                return await _context.Set<T>().ToListAsync();
            }
        }

        public async Task<TEntity> UpdatePartialAsync<TEntity>(int id, Action<TEntity> updateAction) where TEntity : class
        {
            var toUpdate = await _dbContext.Set<TEntity>().FindAsync(id);
            if (toUpdate == null)
            {
                MessageHandler.ShowError($"{typeof(TEntity).Name} not found for id: {id}");
                return null;
            }

            updateAction(toUpdate);
            await _dbContext.SaveChangesAsync();
            return toUpdate;
        }

    }

}
