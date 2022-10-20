using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Academy.BookStore.Entities;
using Academy.BookStore.Entities.Models;

namespace Academy.BookStore.Services
{
    public abstract class EntityService<TEntity>:IEntityService<TEntity> where TEntity:class,IEntity
    {
        protected readonly BookStoreContext _context;
        public EntityService(BookStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);

        public abstract void Add(TEntity entity);

        public abstract void Update(TEntity entity);

        public abstract void Remove(int id);
    }
}