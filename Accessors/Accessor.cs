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
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    _dbContext.Set<T>().Add(entity);
                    await _dbContext.SaveChangesAsync();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving {entity}. Error details: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> UpdateAsync<TModel>(int id, TModel model) where TModel : class
        {
            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    var entity = await _dbContext.Set<TModel>().FindAsync(id);
                    if (entity == null)
                    {
                        return false;
                    }

                    var primaryKeyProperty = _dbContext.Model.FindEntityType(typeof(TModel))
                        .FindDeclaredPrimaryKey()
                        .Properties
                        .FirstOrDefault();

                    foreach (var property in _dbContext.Entry(entity).CurrentValues.Properties)
                    {
                        if (property.Name == primaryKeyProperty?.Name)
                        {
                            continue;
                        }

                        _dbContext.Entry(entity).CurrentValues[property.Name] = property.PropertyInfo.GetValue(model);
                    }

                    await _dbContext.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating {model} with id {id}. Error details: {ex.Message}");
                throw;
            }
        }


        public async Task SoftDeleteAsync(int id)
        {
            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    var entity = await _dbContext.Set<T>().FindAsync(id);

                    if (entity == null)
                    {
                        MessageHandler.ShowError($"Entity with id {id} not found.");
                        return;
                    }

                    entity.IsDeleted = true;

                    await _dbContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error soft deleting entity with id {id}. Error details: {ex.Message}");
                throw;
            }
        }


        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    return await _dbContext.Set<T>().FindAsync(id);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error geting entity with id {id}. Error details: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                using (var _dbContext = new DatabaseContext())
                {
                    return await _dbContext.Set<T>().ToListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error geting all data. Error details: {ex.Message}");
                throw;
            }
        }
    }
}
