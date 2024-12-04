using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesPro.Accessors
{
    public class GenericAccessor<T> where T : BaseEntity
    {
        private readonly DatabaseContext _dbContext;
        public GenericAccessor(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Add(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving {entity}. Error details: {ex.Message}");
                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Update(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error updating {entity}. Error details: {ex.Message}");
                throw;
            }
        }

        public async Task SoftDeleteAsync(int id)
        {
            try
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
                return await _dbContext.Set<T>().FindAsync(id);
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
                return await _dbContext.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error geting all data. Error details: {ex.Message}");
                throw;
            }
        }


    }
}
