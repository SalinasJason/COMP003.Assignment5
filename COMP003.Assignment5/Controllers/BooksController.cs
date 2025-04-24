using COMP003.Assignment5.Data;
using COMP003.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003.Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(BookStore.Books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = BookStore.Books.FirstOrDefault(p => p.Id == id);

            if (book == null)
            {
                return NotFound(null);
            }

            return Ok(book);
        }
    }
}



