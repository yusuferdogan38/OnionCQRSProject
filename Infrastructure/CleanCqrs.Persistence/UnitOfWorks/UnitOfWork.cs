using CleanCqrs.Application.Repositories;
using CleanCqrs.Application.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCqrs.Persistence.Context;

using CleanCqrs.Persistence.Repositories;

namespace CleanCqrs.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfwork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();
        public int Save() => dbContext.SaveChanges();
        public Task<int> SaveAsync() => dbContext.SaveChangesAsync();
        IReadRepository<T> IUnitOfwork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);
        IWriteRepository<T> IUnitOfwork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);

    }
}
