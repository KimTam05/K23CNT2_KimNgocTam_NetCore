using Lesson04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Controllers
{
    public class KntBookController : Controller
    {
        protected Book book = new Book();

        public IActionResult KntIndex()
        {
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres;
            var books = book.GetBooksList();
            return View(books);
        }

        public IActionResult KntCreate()
        {
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres;
            Book newBook = new Book();
            return View(newBook);
        }

        public IActionResult KntEdit(int id)
        {
            ViewBag.Authors = book.Authors;
            ViewBag.Genres = book.Genres;
            Book editBook = book.GetBookById(id);
            return View(editBook);
        }
    }
}
