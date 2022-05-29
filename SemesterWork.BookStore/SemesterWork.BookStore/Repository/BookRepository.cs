using SemesterWork.BookStore.Data;
using SemesterWork.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SemesterWork.BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
         
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdatedOn = DateTime.UtcNow
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();

            return newBook.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }   
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Urazalin", Description = "Description for MVC book", Category="Programming", Language="English", TotalPages=134},
                new BookModel() { Id = 2, Title = "Java", Author = "Urazalin", Description = "Description for Java book", Category="Framework", Language="Chinese", TotalPages=567},
                new BookModel() { Id = 3, Title = "C#", Author = "Urazalin", Description = "Description for C# book", Category="Developer", Language="Hindi", TotalPages=897},
                new BookModel() { Id = 4, Title = "PHP", Author = "Urazalin", Description = "Description for PHP book", Category="Concept", Language="English", TotalPages=564},
                new BookModel() { Id = 5, Title = "JS", Author = "Urazalin", Description = "Description for JS book", Category="DevOps", Language="English", TotalPages=800},
            };
        }
    }
}
