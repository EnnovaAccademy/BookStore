using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.BookStore.Entities.Models
{
    public class Author:IEntity
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        public virtual IList<Book> Books { get; set; }
               
    }
}