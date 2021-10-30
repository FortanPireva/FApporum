using System.Collections.Generic;
using FormumApp.Domain.Entities;

namespace ForumApp.Application.Contracts.Persistence
{
    
    public interface IAsyncRepository<T> where T: BaseEntity
    {
        public bool AddAsync(T entity);
        public T GetByIdAsync(string id);
        public IList<T> GetAsync();
        public IList<T> GetPaginationAsync();
        public bool UpdateAsync(T entity);
        public bool DeleteAsync(string id);
    }
}