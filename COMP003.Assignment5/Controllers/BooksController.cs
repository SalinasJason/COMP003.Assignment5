using COMP003.Assignment5.Data;
using COMP003.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003.Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
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

        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            book.Id = BookStore.Books.Max(p => p.Id) + 1;

            BookStore.Books.Add(book);

            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")] 
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var existingBook = BookStore.Books.FirstOrDefault(p =>p.Id == id);

            if (existingBook == null)
                return NotFound();

            existingBook.Title = updatedBook.Title;
            existingBook.Author = updatedBook.Author;
            existingBook.Price = updatedBook.Price;

            return NoContent();
        } 

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookStore.Books.FirstOrDefault(p => p.Id == id);

            if (book == null)
                return NotFound();

            BookStore.Books.Remove(book);

            return NoContent();
        }
    }
}



