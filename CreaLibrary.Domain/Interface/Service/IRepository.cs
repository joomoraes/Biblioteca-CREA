using LibraryCrea.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.Domain.Interface.Service
{
    public interface IRepository<T> where T : BaseEntity 
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<T>> SelecAsynct();
        Task<T> SelecAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
