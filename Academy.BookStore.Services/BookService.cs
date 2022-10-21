using System.Collections.Generic;
using System.Linq;
using Academy.BookStore.Entities;
using Academy.BookStore.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Academy.BookStore.Services
{
    public class BookService : EntityService<Book>, IBookService

    {
        public BookService(BookStoreContext context) : base(context)
        {
        }

        public override IEnumerable<Book> GetAll()
        {

            return _context.Books.Include(a => a.Author).Include(s => s.Stores).ToList();
        }

        public override Book GetById(int id)
        {
            return _context.Books.Where(s => s.Id == id).FirstOrDefault();
        }

        public override void Add(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public override void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }

        public override void Remove(int id)
        {
            _context.Books.Remove(GetById(id));
            _context.SaveChanges();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Where(s => s.Id == id).FirstOrDefault();
        }
        
        public IEnumerable<Store> GetStores(int bookid)
        {
            return (IEnumerable<Store>)_context.Books.Include(s => s.Id == bookid).ToList();
        }
    }
}