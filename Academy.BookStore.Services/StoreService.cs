using System.Collections.Generic;
using System.Linq;
using Academy.BookStore.Entities;
using Academy.BookStore.Entities.Models;

namespace Academy.BookStore.Services
{
    public class StoreService:EntityService<Store>,IStoreService
    {
        public StoreService(BookStoreContext context) : base(context)
        {
        }

        public override IEnumerable<Store> GetAll()
        {
            return _context.Stores.ToList();
        }

        public override Store GetById(int id)
        {
            return _context.Stores.Where(s => s.Id == id).FirstOrDefault();
        }

        public override void Add(Store entity)
        {
            _context.Stores.Add(entity);
            _context.SaveChanges();
        }

        public override void Update(Store entity)
        {
            _context.Stores.Update(entity);
            _context.SaveChanges();
        }

        public override void Remove(int id)
        {
            _context.Stores.Remove(GetById(id));
            _context.SaveChanges();
        }
    }
}