using System;
using System.Collections.Generic;
using System.Linq;
using ProjectTemplate.Core.Abstractions;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class, IEntityKey<int>, IIsDeleted, new()
    {
        protected readonly IRepository Repository;

        public RepositoryBase(IRepository repository)
        {
            Repository = repository;
        }

        public void Insert(TEntity obj)
        {
            Repository.Insert(obj);
        }
        public void Update(TEntity obj)
        {
            Repository.Update(obj);
        }
        public void Delete(TEntity obj)
        {
            Repository.Delete(obj);
        }

        public TEntity GetById(int id)
        {
            return Repository.Select<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Repository.Select<TEntity>().Where(x => x.IsDeleted == false).ToList();
        }

        public void Dispose()
        {
          
        }
    }
}
