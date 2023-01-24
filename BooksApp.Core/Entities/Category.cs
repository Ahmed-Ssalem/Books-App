using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Core.Entities
{
    public class Category : BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
