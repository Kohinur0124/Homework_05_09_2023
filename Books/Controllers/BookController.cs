using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.ViewModel;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        [HttpPost]
        public async Task Create([FromForm] BookViewModel book)
        {
            bookRepository.AddBooks(book);

            //return Ok("Created");
        }
    }
}
