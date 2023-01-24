using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Core.Entities
{
    public class Author : BaseEntity
    {

        [Required]
        [MaxLength(150)]
        public int Name { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
