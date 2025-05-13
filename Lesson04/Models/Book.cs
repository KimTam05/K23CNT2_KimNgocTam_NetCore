namespace Lesson04.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorID { get; set; }
        public string GenreID { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPages { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBooksList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 0,
                    Title = "The Great Gatsby",
                    AuthorID = "F. Scott Fitzgerald",
                    GenreID = "Fiction",
                    Image = "~/images/book_01.png",
                    Price = 10.99f,
                    TotalPages = 180,
                    Sumary = "A novel about the American dream.",
                },
                new Book()
                {
                    Id = 1,
                    Title = "To Kill a Mockingbird",
                    AuthorID = "Harper Lee",
                    GenreID = "Fiction",
                    Image = "~/images/book_02.png",
                    Price = 12.99f,
                    TotalPages = 281,
                    Sumary = "A novel about racial injustice in the Deep South.",
                },
                new Book()
                {
                    Id = 2,
                    Title = "1984",
                    AuthorID = "George Orwell",
                    GenreID = "Dystopian",
                    Image = "~/images/book_03.png",
                    Price = 15.99f,
                    TotalPages = 328,
                    Sumary = "A novel about a totalitarian regime that uses surveillance to control its citizens."
                },
            };
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBooksList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get;  } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "F. Scott Fitzgerald" },
            new SelectListItem { Value = "2", Text = "Harper Lee" },
            new SelectListItem { Value = "3", Text = "George Orwell" } 
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Fiction" },
            new SelectListItem { Value = "2", Text = "Dystopian" },
            new SelectListItem { Value = "3", Text = "Science Fiction" }
        };
}