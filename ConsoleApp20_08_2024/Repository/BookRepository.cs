﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ConsoleApp20_08_2024.Abstract;
using WpfApp2.ConsoleApp20_08_2024.Enities;
using WpfApp2.ConsoleApp20_08_2024.Exceptions;

namespace WpfApp2.ConsoleApp20_08_2024.Repository
{
    public class BookRepository : IBookRepository
    {
        public readonly MyDbContext _context;
        public const int BatchCount = 10;

        public BookRepository(MyDbContext context)
        {
            _context = context;
        }

        public Book GetBookByName(string name)
        {
            var book = _context.Books.FirstOrDefault(x => x.Name == name);
            if (book is null)
            {
                throw new EntityNotFoundException($"Book by name ({name}) not found!");
            }
            return book;
        }

        public (int curPage, int allPage, Book[] books) GetBooksByAuthor(Author author, int page = 1)
        {
            if (page < 1)
            {
                page = 1;
            }
            var count = _context.Books.Where(x => x.AuthorId == author.Id).Count();
            int allPage = (count / BatchCount) + 1;
            if (page > allPage)
            {
                page = allPage;
            }
            var books = _context.Books.Where(x => x.AuthorId == author.Id).Skip((page - 1) * BatchCount).Take(BatchCount);
            return (page, allPage, books.ToArray());
        }

        public bool CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            //var newBook = _context.Books.FirstOrDefault(x => x.Name == book.Name && x.Description == book.Description && x.AuthorId == book.AuthorId);
            //if (newBook is null)
            //{
            //    return false;
            //}
            return true;
        }

        public bool EditBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
            return true;
        }
    }
}
