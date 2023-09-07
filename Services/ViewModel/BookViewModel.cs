using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModel
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public int Price { get; set; }

        public Guid GanreId { get; set; }
    }
}
