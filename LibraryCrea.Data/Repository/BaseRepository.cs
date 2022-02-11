
using LibraryCrea.Data.Context;
using LibraryCrea.Domain.Entities;
using LibraryCrea.Domain.Interface.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                    return false;

                _context.Remove(result);
                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));

        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<IEnumerable<T>> SelecAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> SelecAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.FirstOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
