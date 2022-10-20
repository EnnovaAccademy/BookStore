using System.IO;
using Academy.BookStore.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Academy.BookStore.Entities
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext() 
    {

    }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();
            var connectionString = config["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Author> Authors { get; set; }
      public DbSet<Book> Books { get; set; }
      public DbSet<Store> Stores { get; set; }
    }
}