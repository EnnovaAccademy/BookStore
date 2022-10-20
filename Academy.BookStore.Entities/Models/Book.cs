using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Academy.BookStore.Entities.Models
{
    [Index(nameof(Book.Title), IsUnique = true)]
    public class Book:IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        
        public string Title { get; set; }
        [Column(TypeName = nameof(DataType.Date))]
        public DateTime? PublishingYear { get; set; }
        public int PagesCount { get; set; }
        
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual IList<Store> Stores { get; set; }
    }
}