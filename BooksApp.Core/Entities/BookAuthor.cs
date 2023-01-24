using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Core.Entities
{
    public class BookAuthor : BaseEntity
    {
        public long BookId { get; set; }
        public Book Book { get; set; }

        public long AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
