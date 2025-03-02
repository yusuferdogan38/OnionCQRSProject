using CleanCqrs.Application.Repositories;
using CleanCqrs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCqrs.Application.UnitOfWorks
{
    public interface IUnitOfwork:IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
        
        Task<int> SaveAsync();

        int Save();
    }
}
