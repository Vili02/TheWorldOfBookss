using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorldOfBookss.Data.Models
{
    public class Genre : BaseModel
    {
        [Required]
        public string Title { get; set; }
        public ICollection<Book> Books { get; set; }

        public Genre()
        {
            Id = Guid.NewGuid();
            Books = new HashSet<Book>();
        }
    }
}
