using Car_Parts_API.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;

namespace CarParts.API.Infrastructure.Data.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CarPartsContext _context;
        protected readonly DbSet<T> _dbSet;


        public Repository(CarPartsContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        //public  Task DeleteAsync(T entity)
        //{
        //     _dbSet.Remove(entity);
        //    return Task.CompletedTask;
        //}

        public async Task<bool> DeleteAsync(int id)
        {
            var t = await _dbSet.FindAsync(id);

            if (t != null)
            {
                _dbSet.Remove(t);
                return true;
            }
            else
                return false;
        }



        //public async Task<IEnumerable<T>> GetAllAsync()
        //{
        //    return await _dbSet.ToListAsync();
        //}

        // async Task<List<Part>> GetAllAsync()
        public async Task<List<T>> GetAllAsync()
        {
            //return await _dbSet
            //    .Include(p=>p.VehicleMake)
            //    .Include(p=>p.VehicleModel)
            //    .Include(p=>p.Price)
            //    .ToList();
            return await _dbSet.ToListAsync();
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
