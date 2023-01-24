using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksApp.Core.Entities
{
    public class Book : BaseEntity
    {


        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        public DateTimeOffset PublishYear { get; set; }
        
        public int NumberOfPapers { get; set; }
        
        public string ImageUrl { get; set; }
        
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookCategory> BookCategories { get; set; }

    }
}
