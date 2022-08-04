using System;

namespace Emirates.Core.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;

        int Complete();
        void BeginTransaction();
        void RollBackTransaction();
        void CommitTransaction();
    }

    public interface IUnitOfWork<TContext> : IDisposable 
        where TContext: IDisposable 
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        TContext Context { get; }

        int Complete();
        void BeginTransaction();
        void RollBackTransaction();
        void CommitTransaction();
    }
}
