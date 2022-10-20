using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Academy.BookStore.Entities.Models
{
    public class Store:IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public IList<Book> Books { get; set; }
    }
}