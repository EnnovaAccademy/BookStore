using System;
using System.Collections.Generic;
using Academy.BookStore.Entities.Models;

namespace Academy.BookStore.Services
{
    public interface IEntityService<TEntity> where TEntity:IEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}