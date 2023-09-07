using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }  

        public Guid GanreId { get; set; }

        public Ganres Ganres { get; set; }
        public ICollection<Author> Author { get; set; }
    }
}
