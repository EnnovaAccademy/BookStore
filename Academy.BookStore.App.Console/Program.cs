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


            var book = bs.GetAll();

            foreach (var item in book)
            {
                Console.WriteLine(item.Author.FirstName);
                if (item.Id == 5)
                {
                    foreach (var item2 in item.Stores)
                    {
                        Console.WriteLine(item2.Address);
                    }
                }
            }
        }
    }
}