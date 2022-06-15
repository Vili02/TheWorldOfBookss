using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldOfBookss.Data.Models
{
    public class Book
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Published { get; set; }
        [Required]
        public string Pages { get; set; }
        [Required]
        public int PageCount { get; set; }
        [Required]
        public Guid GenreId { get; set; }
        public Guid AuthorId { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
    }
}
