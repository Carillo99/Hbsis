using IncomeTax.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeTax.Domain.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(string includes);
        IEnumerable<TEntity> GetAll();
    }
}
