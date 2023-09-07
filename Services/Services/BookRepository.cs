using AutoMapper;
using Models;
using Npgsql.TypeMapping;
using Services.Data;
using Services.Interfaces;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BookRepository : IBookRepository

    {

        public readonly DataBooks dbContext;
        public IMapper Mapper; 
        public BookRepository(DataBooks dataBooks,IMapper mapper)
        {
            dbContext = dataBooks;
            Mapper = mapper;
            
        }
        public async Task AddBooks(BookViewModel viewModel)
        {
            var book = Mapper.Map<Book> (viewModel);
            book.BookId = new Guid();
            await dbContext.Book.AddAsync(book);
            await dbContext.SaveChangesAsync();
            
        }

        public Task DeleteBooks(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookViewModel>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBooks(Guid id, BookViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
