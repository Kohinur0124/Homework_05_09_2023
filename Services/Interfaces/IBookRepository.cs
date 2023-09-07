using Services.Data;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookRepository
    {
       
        public Task  AddBooks(BookViewModel viewModel);

        public Task UpdateBooks(Guid id,BookViewModel viewModel);

        public Task DeleteBooks(Guid id);

        public Task<IEnumerable<BookViewModel>> GetAllBooks();
    }
}
