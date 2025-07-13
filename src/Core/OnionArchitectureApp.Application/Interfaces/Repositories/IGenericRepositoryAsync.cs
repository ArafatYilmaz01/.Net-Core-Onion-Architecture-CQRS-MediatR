using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionArchitectureApp.Domain.Common;
namespace OnionArchitectureApp.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
    }
}