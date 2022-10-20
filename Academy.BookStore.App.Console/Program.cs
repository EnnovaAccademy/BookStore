using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Academy.BookStore.Entities;
using Academy.BookStore.Entities.Models;
using Academy.BookStore.Services;
using Microsoft.EntityFrameworkCore;

namespace Academy.Students.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookStoreContext(); 
            context.Database.Migrate();
            Console.WriteLine($"How many books: {context.Books.Count()}");
            //var book = context.Books.FirstOrDefault(x => x.Title == "My name is Joe Black");
            //if (book == null)
            //{
            //    var author = new Author
            //    {
            //        FirstName = "Michele",
            //        LastName = "Cofano"
            //    };
            //    book = new Book
            //    {
            //        Author = author,
            //        Title = "My name is Michele Cofano",
            //        PublishingYear = new DateTime(2008,9,12)
            //    };
            //    context.Books.Add(book);
            //    context.SaveChanges();
            //}
            
            //Console.WriteLine($"How many books: {context.Books.Count()}");

            AuthorService _as = new(context);
            BookService bs = new(context);
            StoreService ss = new(context);

            var authors = _as.GetAll();
            var stores = ss.GetAll();
            //foreach (Author author in authors)
            //{
            //    Console.WriteLine(author.FirstName + " " + author.LastName);
            //}
            Book book = bs.GetById(5);
            Console.WriteLine(book.Author.FirstName + " " + book.Author.LastName);
            
            Store s = ss.GetById(1);
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Address);
            context.SaveChanges();
            if (book.Stores == null)
            {
                Console.WriteLine("Ciao carino");
            }
            foreach (Store sium in book.Stores)
            {
                Console.WriteLine(sium.Address);
            }



        }
    }
}