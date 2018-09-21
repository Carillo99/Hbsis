using IncomeTax.Domain.Entities;
using IncomeTax.Domain.Repository;
using IncomeTax.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IncomeTax.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly ApplicationDbContext _context;
        
        protected Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAll( string includes)
        {

            var contexto = _context.Set<TEntity>().AsQueryable();

            if (!string.IsNullOrEmpty(includes))
            {
                var includesArray = includes.Split(',');

                foreach (var include in includesArray)
                {
                    contexto = contexto.Include(include);
                }
            }

            return contexto;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
