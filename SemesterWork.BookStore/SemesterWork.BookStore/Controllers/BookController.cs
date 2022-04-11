﻿using Microsoft.AspNetCore.Mvc;
using SemesterWork.BookStore.Models;
using SemesterWork.BookStore.Repository;
using System.Collections.Generic;

namespace SemesterWork.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }

    }
}