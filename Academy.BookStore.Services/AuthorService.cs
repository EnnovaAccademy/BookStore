using System.Collections.Generic;
using System.Linq;
using Academy.BookStore.Entities;
using Academy.BookStore.Entities.Models;

namespace Academy.BookStore.Services
{
    public class AuthorService:EntityService<Author>,IAuthorService
    {
        public AuthorService(BookStoreContext context) : base(context)
        {
            
        }


        public override IEnumerable<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public override Author GetById(int id)
        {
            return _context.Authors.Where(s => s.Id == id).FirstOrDefault();
        }

        public override void Add(Author entity)
        {
            _context.Authors.Add(entity);
            _context.SaveChanges();
        }

        public override void Update(Author entity)
        {
            _context.Authors.Update(entity);
            _context.SaveChanges();
        }

        public override void Remove(int id)
        {
            _context.Authors.Remove(GetById(id));
            _context.SaveChanges();
        }
    }
}